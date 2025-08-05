﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_lists.Main
{
    public class Core
    {
        private List<string> _iceCreams = new List<string>()
        {
            "Strawberry Cheesecake",
            "Chocolate Fudge Brownie",
            "Cookie Dough",
            "Strawberry Cheesecake",
            "Caramel Chew Chew"
        };

        public Core()
        {

        }

        public List<string> Question1()
        {
            //TODO:  Lists in C# are a collection object that can store generic types.
            //       e.g.  the  List<string> _question1 = new List<string>() line above 
            //       declares a List<string>  which is a collection of strings.
            //       by typing _iceCreams.  intellisense shows all of the methods associated with the _inceCreams list.
            //  TODO:  1.  Find the add method and add two more flavours of ice cream: "Phish Food", "Peanut Butter Cup"

            //write code here
            _iceCreams.Add("Phish Food");
            _iceCreams.Add("Peanut Butter Cup");



            return _iceCreams;
        }

        public int Question2()
        {

            //TODO:  find the lists method that returns the number of ice creams in the list and return this.

            return _iceCreams.Count;
        }
        public List<string> Question3()
        {

            // The code below concatenates this.MoreIceCream to the _iceCreams list into a new results list.
            // TODO: you can 'chain' methods on the _iceCream list, so add another Concat to
            // include EvenMoreIceCream  (this is defined below) to the result list . e.g.
            // _iceCreams.Concat(this.MoreIceCream).Concat(other list to concat).ToList()

            List<string> results = _iceCreams.Concat(this.MoreIceCream).Concat(this.EvenMoreIceCream).ToList();

            return results;

            // remove exception and write code here

        }
        public List<string> Question4()
        {

            //TODO: Remove the duplicates using the .Distinct() placing just before the .ToList()
            //      copy the List declaration line from Question3 and add the .Distinct() into the chain.
            //      e.g.  _iceCreams.Concat(this.MoreIceCream).Concat(other list to concat).Distinct().ToList()
            //      be sure to include the MoreIceCream and EvenMoreIceCream lists


            List<string> results = _iceCreams.Concat(this.MoreIceCream).Concat(this.EvenMoreIceCream).Distinct().ToList();

            return results;
        }

        public List<string> MoreIceCream = new List<string>()
        {
                "Minter Wonderland Ice Cream",
                "Half Baked",
                "Chocolate Fudge Brownie",
                "Baked Alaska",
                "Strawberry Cheesecake"
        };
        public List<string> EvenMoreIceCream = new List<string>()
        {
                "Praline",
                "Cookie Dough",
                "Strawberry Cheesecake",
                "Vanilla"
        };


    }
}
