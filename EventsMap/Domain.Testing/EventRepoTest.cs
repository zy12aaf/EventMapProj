using System;
using System.Linq;
using DataAccess;
using Domain.Enums;
using Domain.HelperModel;
using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Testing
{
    [TestClass]
    public class EventRepoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var ctx = new EventMapContext())
            {
                var repo = new EventRepo(ctx);

                var findEventWithSearchModel = repo.FindEventWithSearchModel(new SearchingModel()
                {
                    Keyword = "amb"
                });
                var events = ctx.Events.ToList();
            }
        }
    }
}
