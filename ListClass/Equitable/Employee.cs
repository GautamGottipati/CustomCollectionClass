﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equitable
{
    class Employee : IEquatable<Employee>
    {
        public string Account;
        public string Name;

        public Employee(string account, string name)
        {
            this.Account = account;
            this.Name = name;
        }

        public bool Equals(Employee other)
        {
            if (other == null) return false;
            return (this.Account.Equals(other.Account));
        }
    }
}
