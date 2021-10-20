using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestApp
{
    class Program
    {
        static void Main(string[] args)
        {   // List<int>arr = new List<int> {5, 7, 9, 1, 3, 10};
            // arr.Sort();

            var profiles = new List<Profile>();

            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 157 });
            profiles.Add(new Profile() { Name = "전지현", Height = 171 });
            profiles.Add(new Profile() { Name = "박소담", Height = 169 });
            profiles.Add(new Profile() { Name = "우도환", Height = 178 });
            profiles.Add(new Profile() { Name = "서현진", Height = 163 });
            profiles.Add(new Profile() { Name = "주지훈", Height = 192 });

            var profiles1 = from item in profiles
                            orderby item.Height descending
                            select new { Name = item.Name, Inch = item.Height * 0.393 };

            Console.WriteLine($"전체 프로필 리스트(키 내림차순)");
            foreach (var item in profiles1)
            {
                Console.WriteLine($"{item.Name} : {item.Inch} inch. ");
            }

            /* var newProfiles = new List<Profile>();
            foreach (var item in profiles)
            {
                if (item.Height < 172)
                    newProfiles.Add(item);
            }
            */


            // using System.linq 추가
            var newProfiles = from item in profiles
                              where item.Height < 172
                              orderby item.Height descending  // 내림차순정렬
                              select item;
            Console.WriteLine("172이하 프로필 리스트");

            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm. ");
            }

            //
            int maxSize = 100;
            int[] numbers = new int[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                numbers[i] = (i + 1);
            }
            
            var result = from item in numbers
                         where (item % 10 == 3 || item % 10 == 6 || item % 10 == 9 ||
                                item / 10 == 3 || item / 10 == 6 || item / 10 == 9 )
                         select item;

            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            //15.3
            // 60점 미만인 학생이 있는 반 과 점수를 찾겠다
            InstClass[] arrClasses =
            {
                new InstClass() { Name = "연두반", Scores = new int[] {99, 80, 70, 29}},
                new InstClass() { Name = "분홍반", Scores = new int[] {60, 45, 87, 72}},
                new InstClass() { Name = "파랑반", Scores = new int[] {92, 30, 85, 95}},
                new InstClass() { Name = "노랑반", Scores = new int[] {90, 88, 0, 17}},
            };

            var rstClasses = from item in arrClasses
                            from score in item.Scores
                            where score < 60
                            orderby score ascending
                            select new { Name = item.Name, Lowest = score };
            
            foreach (var item in rstClasses)
            {
                Console.WriteLine($"{item.Name} : {item.Lowest}");
            }
            Console.WriteLine();            Console.WriteLine();

            //15.4
            // groupby
            var listprofiles = from item in profiles
                               group item by item.Height < 172 into g
                               select new { GroupKey = g.Key, Profiles = g };

            foreach (var item in listprofiles)
            {
                Console.WriteLine($"- 172cm 미만 : {item.GroupKey}");

                foreach (var sub in item.Profiles)
                {
                    Console.WriteLine($">>> {sub.Name} : {sub.Height} ");
                }
            }


        }
    }
}
