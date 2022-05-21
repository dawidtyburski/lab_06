using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace lab_06
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var user = new ObservableCollection<User>();
            user.Add(new User() { Name = "Dawid", Role = "ADMIN", Age = 27, Marks = null, CreatedAt = new DateTime(2020, 01, 20) }); //1
            user.Add(new User() { Name = "Marcin", Role = "MODERATOR", Age = 24, Marks = null, CreatedAt = new DateTime(2020, 02, 20) });//2
            user.Add(new User() { Name = "Maciek", Role = "MODERATOR", Age = 22, Marks = null, CreatedAt = new DateTime(2020, 03, 20) });//3
            user.Add(new User() { Name = "Kasia", Role = "TEACHER", Age = 31, Marks = null, CreatedAt = new DateTime(2021, 01, 20) });//4
            user.Add(new User() { Name = "Zosia", Role = "TEACHER", Age = 28, Marks = null, CreatedAt = new DateTime(2020, 02, 20) });//5
            user.Add(new User() { Name = "Jola", Role = "TEACHER", Age = 25, Marks = null, CreatedAt = new DateTime(2020, 04, 20) });//6
            user.Add(new User() { Name = "Zdzisio", Role = "STUDENT", Age = 17, Marks = new int[] { 1, 2 }, CreatedAt = new DateTime(2021, 09, 01) });//7
            user.Add(new User() { Name = "Tomek", Role = "STUDENT", Age = 18, Marks = new int[] { 1, 3, 2 }, CreatedAt = new DateTime(2021, 09, 01) });//8
            user.Add(new User() { Name = "Mariusz", Role = "STUDENT", Age = 16, Marks = new int[] { 5, 2 }, CreatedAt = new DateTime(2021, 09, 01) });//9
            user.Add(new User() { Name = "Kacper", Role = "STUDENT", Age = 15, Marks = new int[] { 1, 2, 4 }, CreatedAt = new DateTime(2021, 09, 01) });//10
            user.Add(new User() { Name = "Marta", Role = "STUDENT", Age = 16, Marks = new int[] { 5, 3 }, CreatedAt = new DateTime(2021, 09, 01) });//11
            user.Add(new User() { Name = "Iza", Role = "STUDENT", Age = 17, Marks = new int[] { 4, 2, 5 }, CreatedAt = new DateTime(2021, 09, 01) });//12
            user.Add(new User() { Name = "Basia", Role = "STUDENT", Age = 18, Marks = new int[] { 1, 1, 1 }, CreatedAt = new DateTime(2021, 09, 01) });//13
            user.Add(new User() { Name = "Ewelina", Role = "STUDENT", Age = 19, Marks = new int[] { 1, 2, 2 }, CreatedAt = new DateTime(2021, 09, 01) });//14
            user.Add(new User() { Name = "Sebastian", Role = "STUDENT", Age = 15, Marks = new int[] { 2, 2, 2 }, CreatedAt = new DateTime(2021, 09, 01) });//15
            user.Add(new User() { Name = "Krysia", Role = "STUDENT", Age = 16, Marks = new int[] { 1, 1 }, CreatedAt = new DateTime(2021, 09, 01) });//16
            user.Add(new User() { Name = "Paweł", Role = "STUDENT", Age = 17, Marks = new int[] { 5, 5 }, CreatedAt = new DateTime(2021, 09, 01) });//17
            user.Add(new User() { Name = "Jacek", Role = "STUDENT", Age = 14, Marks = new int[] { 3, 3 }, CreatedAt = new DateTime(2021, 09, 01) });//18
            user.Add(new User() { Name = "Julia", Role = "STUDENT", Age = 15, Marks = new int[] { 3, 2 , 3}, CreatedAt = new DateTime(2021, 09, 01) });//19
            user.Add(new User() { Name = "Konrad", Role = "STUDENT", Age = 16, Marks = new int[] { 4, 4 }, CreatedAt = new DateTime(2021, 09, 01) });//20


            //Ilość rekordów w tablicy
            Console.WriteLine($"Ilosc rekordow w tablicy: {user.Count}");
            
            //Listę nazw użytkowników    
            var name = from n in user
                       select n.Name;
            foreach(var n in name)
            {
                Console.WriteLine(n);
            }

            //Posortowanych użytkowników po nazwach
            var nameSorted = from ns in user
                       orderby ns.Name descending
                       select ns.Name;
            foreach (var ns in nameSorted)
            {
                Console.WriteLine(ns);
            }
            
            //Listę dostępnych ról użytkowników
            var role = from r in user
                       select r.Role;
            List<string> roles = new List<string>();
            foreach(var r in role)
            {
                if(roles.IndexOf(r) < 0)
                {
                    roles.Add(r);
                }

            }
            foreach (var r in roles)
            {
                Console.WriteLine(r);
            }

            //Listy pogrupowanych użytkowników po rolach
            var us = from u in user
                     select u;
            
            for(int i = 0; i<roles.Count; i++)
            {
                foreach(var u in us)
                {
                    if(u.Role == roles[i])
                    {
                        Console.WriteLine($"{ u.Role}  { u.Name}");
                    }
                }
            }



        }
    }
}
