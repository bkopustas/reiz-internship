using System;

namespace TreeDepth
{
    public class Branch
    {
        public List<Branch> branches;

        public Branch(List<Branch> branches)
        {
            this.branches = branches;
        }
        public Branch()
        {
            this.branches = new List<Branch>();
        }
    }
}
