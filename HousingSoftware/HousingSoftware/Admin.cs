﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    public class Admin
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;

        // Lists
        private List<Tenant> tenants = new List<Tenant>();
        private List<Grocery> allGroceries = new List<Grocery>();
        private List<string> complaints = new List<string>();
        private List<Agreements> agreements = new List<Agreements>();
        private List<Announcements> announcements = new List<Announcements>();
        private List<HouseRules> houseRules = new List<HouseRules>();

        public Admin(string username, string password, string firstName, string lastName)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
        }



        //  USERNAME
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }


        // First name
        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }

        // Last name
        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }


        //  PASSWORD

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        //  MANAGE TENANTS
        public void AddTenant(Tenant inputedTenant)
        {
            tenants.Add(inputedTenant);
        }

        public void RemoveTenant(Tenant inputedTenant)
        {
            tenants.Remove(inputedTenant);
        }

        public void RemoveTenantAt(int index)
        {
            tenants.RemoveAt(index);
        }

        public List<Tenant> Tenants
        {
            get { return this.tenants; }
            set { this.tenants = value; }
        }

        //  MANAGE GROCERIES

        public List<Grocery> Groceries
        {
            get { return this.allGroceries; }
            set { this.allGroceries = value; }
        }

        public void AddGrocery(Grocery grocery)
        {
            allGroceries.Add(grocery);
        }

        public void RemoveGrocery(Grocery grocery)
        {
            allGroceries.Remove(grocery);
        }

        public void RemoveGroceryAt(int index)
        {
            allGroceries.RemoveAt(index);
        }

        public void RemoveAllGroceries()
        {
            allGroceries.Clear();
        }

        //  COMPLAINTS
        public void AddComplaint(string newComplaint)
        {
            complaints.Add(newComplaint);
        }

        public void RemoveComplaint(string selectedComplaint)
        {
            complaints.Remove(selectedComplaint);
        }

        public List<string> Complaints
        {
            get { return this.complaints; }
            set { this.complaints = value; }
        }

        // AGREEMENTS
        public void AddAgreement(Agreements newAgreements)
        {
            agreements.Add(newAgreements);
        }

        public List<Agreements> Agreements
        {
            get { return this.agreements; }
            set { this.agreements = value; }
        }

        // ANNOUNCEMENTS
        public void AddAnnouncement(Announcements announcement)
        {
            announcements.Add(announcement);
        }
        public List<Announcements> Announcements
        {
            set { this.announcements = value; }
            get { return this.announcements; }
        }
        
        // House Rules
        public void AddHouseRule(HouseRules HouseRule)
        {
            houseRules.Add(HouseRule);
        }

        public List<HouseRules> HouseRules
        {
            set { this.houseRules = value; }
            get {return this.houseRules; }
        }

    }
}
