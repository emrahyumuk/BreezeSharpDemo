using Breeze.Sharp;

namespace BreezeSharpDemo.WinForms.Models {
    public class Category:BaseEntity {
        public int Id {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public string Name {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
