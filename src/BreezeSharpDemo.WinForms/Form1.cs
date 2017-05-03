using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Breeze.Sharp;
using BreezeSharpDemo.WinForms.Models;

namespace BreezeSharpDemo.WinForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Run();
        }

        private async void Run() {
            Configuration.Instance.ProbeAssemblies(typeof(Product).Assembly);
            var entityManager = new EntityManager("http://localhost:50579/breeze/Products");
            entityManager.MetadataStore.NamingConvention = new NamingConvention().WithClientServerNamespaceMapping("BreezeSharpDemo.WinForms.Models", "BreezeSharpDemo.Models");
            entityManager.MetadataStore.AllowedMetadataMismatchTypes = MetadataMismatchTypes.AllAllowable;
            var query = new EntityQuery<Product>();
            var products = await entityManager.ExecuteQuery(query);
            var product1 = products.First();
            product1.Description = "Desc Modified";
            await entityManager.SaveChanges();
        }

        private void btnRun_Click(object sender, EventArgs e) {
            Run();
        }
    }
}
