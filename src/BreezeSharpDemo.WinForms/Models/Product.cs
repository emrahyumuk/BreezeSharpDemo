using System;
using Breeze.Sharp;

namespace BreezeSharpDemo.WinForms.Models {
    public class Product : BaseEntity {
        public int Id {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public string Name {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public string Description {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public decimal? Price {
            get { return GetValue<decimal?>(); }
            set { SetValue(value); }
        }
        public int? CategoryId {
            get { return GetValue<int?>(); }
            set { SetValue(value); }
        }

        public Category Category {
            get { return GetValue<Category>(); }
            set { SetValue(value); }
        }
    }
}
