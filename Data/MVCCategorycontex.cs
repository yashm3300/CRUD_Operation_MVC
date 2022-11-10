using CategoryMaster.Models.Domain;
using Microsoft.EntityFrameworkCore;
namespace CategoryMaster.Data
{
    public class MVCCategorycontex : Categorycontex
    {
        public MVCCategorycontex(Categorycontex options) : base(options)
        {

        }

        public Categoryset<CategoryDetail> MyProperty { get; set; }
    }
}
