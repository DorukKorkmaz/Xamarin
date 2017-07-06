using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListViewExample
{
    public class DSFactory
    {
        public class DS
        {
            public String Name { get; set; }
            public String Type { get; set; }
        }

        public class Group : List<DS>
        {
            public String Key { get; set; }
            public Group(String key, List<DS> items)
            {
                Key = key;
                foreach (var item in items)
                {
                    this.Add(item);
                }
            }

            public Group()
            {
            }
        }

        public static IList<DS> DSData { get; set; }

        static DSFactory()
        {
            DSData = new ObservableCollection<DS>{
                new DS{
                    Name = "List",
                    Type = "Data Structures"
                },
                new DS{
                    Name = "Array",
                    Type = "Data Structures"
                },
                new DS{
                    Name = "Stack",
                    Type = "Data Structures"
                },
                new DS{
                    Name = "Queue",
                    Type = "Data Structures"
                },
                new DS{
                    Name = "Hash Table",
                    Type = "Data Structures"
                },
                new DS{
                    Name = "Heap",
                    Type = "Data Structures"
                },
                new DS{
                    Name = "Binary Search Tree",
                    Type = "Data Structures"
                },
                new DS{
                    Name = "Bubble Sort",
                    Type = "Sort"
                },
                new DS{
                    Name = "Selection Sort",
                    Type = "Sort"
                },
                new DS{
                    Name = "Insertion Sort",
                    Type = "Sort"
                },
                new DS{
                    Name = "Heap Sort",
                    Type = "Sort"
                },
                new DS{
                    Name = "Merge Sort",
                    Type = "Sort"
                },
                new DS{
                    Name = "Quick Sort",
                    Type = "Sort"
                },
                new DS{
                    Name = "Linear Search",
                    Type = "Search"
                },
                new DS{
                    Name = "Binary Search",
                    Type = "Search"
                },
                new DS{
                    Name = "Breadth-First Search",
                    Type = "Search"
                },
                new DS{
                    Name = "Depth-First Search",
                    Type = "Search"
                }
            };
        }

        public class DSGroup : Group
        {
            public String Type { get; set; }
        }

        public static ObservableCollection<Group>
            BindingWithGrouping(string searchText = "")
        {
            var result = DSData;

            if (!String.IsNullOrEmpty(searchText))
            {
                result = result.Where(x => x.Name.ToLower().Contains(
                    searchText.ToLower())).ToList();
            }

            var dataGroup = new DSGroup()
            {
                Type = "Data Structures"
            };
            var sortGroup = new DSGroup()
            {
                Type = "Sort"
            };
            var searchGroup = new DSGroup()
            {
                Type = "Search"
            };

            foreach (var item in result)
            {
                if (item.Type.Equals("Data Structures"))
                {
                    dataGroup.Add(item);
                }
                else if (item.Type.Equals("Sort"))
                {
                    sortGroup.Add(item);
                }
                else if (item.Type.Equals("Search"))
                {
                    searchGroup.Add(item);
                }
            }
            var list = new ObservableCollection<Group>();
            list.Add(dataGroup);
            list.Add(sortGroup);
            list.Add(searchGroup);

            return list;
        }
    }
}
