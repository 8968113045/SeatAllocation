using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFrameworkNew
{
    public class WaitListNodeNew : IComparable<WaitListNodeNew>
    {
        public string rollNo;
        public double rank;
        public int retainStatus;

        public WaitListNodeNew(string rollNo, double rank, int retainStatus)
        {
            this.rollNo = rollNo;
            this.rank = rank;
            this.retainStatus = retainStatus;
        }

        // Max-heap behavior:
        // Higher rank value = worse candidate = higher priority in heap
        public int CompareTo(WaitListNodeNew other)
        {
            int rankCompare = this.rank.CompareTo(other.rank);

            if (rankCompare != 0)
                return rankCompare;

            int retainCompare = this.retainStatus.CompareTo(other.retainStatus);

            if (retainCompare != 0)
                return retainCompare;

            return string.Compare(this.rollNo, other.rollNo, StringComparison.Ordinal);
        }
    }

    public class WaitListNew
    {
        private SortedSet<WaitListNodeNew> set;

        public WaitListNew()
        {
            set = new SortedSet<WaitListNodeNew>();
        }

        public int size()
        {
            return set.Count;
        }

        public bool isEmpty()
        {
            return set.Count == 0;
        }

        public void Enqueue(WaitListNodeNew node)
        {
            set.Add(node);
        }

        public WaitListNodeNew PeekMax()
        {
            if (set.Count == 0) return null;
            return set.Max; // worst candidate
        }

        public void RemoveMax()
        {
            if (set.Count == 0) return;
            set.Remove(set.Max);
        }

        public List<WaitListNodeNew> ToList()
        {
            return set.ToList();
        }
    }
}
