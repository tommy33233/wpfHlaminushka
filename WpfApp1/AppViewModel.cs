using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class AppViewModel
    {
        public List<Descriptions> DescriptionsCollection { get; set; }
        public AppViewModel()
        {
            DescriptionsCollection = new List<Descriptions>
            {
                new Descriptions { Name="Opt 1", Desc1 = "AA", Desc2="BB" },
                new Descriptions { Name="Opt 2", Desc1 = "CC", Desc2="DD" },
                new Descriptions { Name="Opt 3", Desc1 = "EE", Desc2="FF" },
            };
        }
    }
}
