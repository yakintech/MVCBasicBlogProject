using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasicBlog.Models.ORM.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }

        private bool _isDeleted = false;
        public bool IsDeleted
        {
            get
            {
                return _isDeleted;
            }
            set
            {
                _isDeleted = value;
            }
        }

        private DateTime _addDate = DateTime.Now;

        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

    }
}