﻿using Shelby.Api.People.Entity;
using Shelby.Api.People.QueryObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shelby.Api;
using Shouldly;

namespace Shelby.Api.Tests.Giving.Batches {
    [TestClass]
    public class ListTests : ContributionBase {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        public void integration_giving_batches_list_all() {
            var response = this.ShelbyRestClient.Giving.Batches.FindAll(new Api.Giving.QueryObject.BatchQO { });
            var results = response.Data;
            results.Count.ShouldBeGreaterThan(0);
        }
    }
}
