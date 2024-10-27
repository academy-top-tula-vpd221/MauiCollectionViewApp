using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionViewApp
{
    public class Flight
    {
        public string Name { set; get; }
        public string ToCity { set; get; }
        public DateOnly Date { set; get; }
        public TimeOnly Time { set; get; }
    }
}
