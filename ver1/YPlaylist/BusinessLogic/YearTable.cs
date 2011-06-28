using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using Castle.Components;
using System.Linq;
using System.Text;
using Castle.ActiveRecord.Queries;
using NHibernate;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    class YearTable : ActiveRecordBase<YearTable>
    {
        private int YearID;
        private string YearName;
        private IList<Album> Album = new List<Album>();


        public YearTable()
        {
        }

        public YearTable(string yn)
        {
            this.YearName = yn;
        }

        [PrimaryKey]
        private int yearID
        {
            get { return YearID; }
            set { YearID = value; }
        }

        [Property]
        public string yearName
        {
            get { return YearName; }
            set { YearName = value; }
        }

        [HasMany(
        Table = "Album", ColumnKey = "YearID",
        Inverse = true, Cascade = ManyRelationCascadeEnum.AllDeleteOrphan)]
        public IList<Album> album
        {
            get { return Album; }
            set { Album = value; }
        }


        public static string[] ReturnAllYearNames()
        {
            int lid = YearTable.Count();

            string[] arr = new string[lid];

            YearTable temp = new YearTable();

            int counter = 0;

            ICriterion[] crit = { Expression.IsNotNull("yearID") };

            YearTable[] allids = (YearTable[])YearTable.FindAll(typeof(YearTable), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (YearTable)YearTable.FindByPrimaryKey(typeof(YearTable), allids[i].yearID);
                arr[counter] = (string)temp.yearName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static YearTable GetYearID(string yname)
        {
            ICriterion[] crit = { Expression.Eq("yearName", yname) };
            YearTable t = (YearTable)FindFirst(typeof(YearTable), crit);
            return t;
        }

    }
}
