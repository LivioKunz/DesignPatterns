using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdapterPattern
{
    public class AdapterTests
    {
        [Fact]
        public void Test_Adapters()
        {
            AdapterA adapterA = new AdapterA(new OtherProduct());
            adapterA.Update(12f,12f);
            Assert.Equal(12f,adapterA.GetHeight());
            AdapterB adapterB = new AdapterB(new Product());
            adapterB.Update(55f,55f);
            Assert.Equal(55f,adapterB.GetHeight());
        }
    }
}
