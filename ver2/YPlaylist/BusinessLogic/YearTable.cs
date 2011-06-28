using System.Collections.Generic;
using Castle.ActiveRecord;
using NHibernate.Criterion;

namespace YPlaylist.BusinessLogic
{
    [ActiveRecord]
    public class YearTable : ActiveRecordBase<YearTable>
    {
        private IList<Album> Album = new List<Album>();

        public YearTable()
        {
        }

        public YearTable(string yn)
        {
            this.YearName = yn;
        }

        [PrimaryKey]
        private int YearId { get; set; }

        [Property]
        public string YearName { get; set; }

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
            YearTable temp;
            int counter = 0;
            ICriterion[] crit = { Expression.IsNotNull("YearId") };
            YearTable[] allids = (YearTable[])YearTable.FindAll(typeof(YearTable), crit);

            for (int i = 0; i < allids.Length; ++i)
            {
                temp = (YearTable)YearTable.FindByPrimaryKey(typeof(YearTable), allids[i].YearId);
                arr[counter] = (string)temp.YearName;
                ++counter;
            }

            string[] temp2 = PlayListElems.RemoveRepeatedElems(arr);

            return temp2;
        }

        public static YearTable GetYearID(string yname)
        {
            ICriterion[] crit = { Expression.Eq("YearName", yname) };
            YearTable t = (YearTable)FindFirst(typeof(YearTable), crit);
            return t;
        }
    }
}
