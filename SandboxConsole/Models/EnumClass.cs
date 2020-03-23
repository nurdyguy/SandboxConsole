﻿using System;

namespace SandboxConsole.Models
{
    public abstract class EnumClass
    {
        protected int _id;
        protected string _name;

        public virtual int Id
        {
            get { return _id; }
        }

        public virtual string Name
        {
            get { return _name; }
        }

        public override string ToString()
        {
            return Name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is EnumClass)
                return Id == (obj as EnumClass).Id;

            return base.Equals(obj);
        }

        public static bool operator ==(EnumClass left, EnumClass right)
        {
            if ((left as Object) == null)
                return (right as Object) == null;

            return left.Equals(right);
        }

        public static bool operator !=(EnumClass left, EnumClass right)
        {
            if ((left as Object) == null)
                return (right as Object) != null;

            return !left.Equals(right);
        }
    }
}
