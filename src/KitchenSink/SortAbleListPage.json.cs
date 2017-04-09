using System;
using Starcounter;

namespace KitchenSink
{
    [SortAbleListPage_json.Persons]
    public partial class Person : Json
    {

    }

    partial class SortAbleListPage : Json
    {
        protected override void OnData()
        {
            InitPage();
            base.OnData();
        }

        private void InitPage()
        {
            AddPersons();
        }

        private void AddPersons()
        {
            //Db.Transact(() =>
            //{
            //    var person = new Person
            //    {
            //        Name = "Konrad",
            //        Surname = "Kubacki",
            //        Order = 14
            //    };
            //});

            this.Persons.Add(new Person(){Name = "Konrad",Surname = "Kubacki",Order = "13"});
            this.Persons.Add(new Person() { Name = "Jan", Surname = "Nowak", Order = "14" });

        }



    }
}
