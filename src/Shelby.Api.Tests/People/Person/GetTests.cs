﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shelby.Api;
using Shouldly;
using Shelby.Api.People.Entity;
using Shelby.Api.People.QueryObject;

namespace Shelby.Api.Tests.People {
    [TestClass]
    class GetTests : BaseTest {
        private int _personID = 183828;

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            base.GetApiSession();
        }

        [TestMethod]
        public void integration_people_get_person() {
            var response = this.ShelbyRestClient.People.Individuals.FindByID(_personID);
            var result = response.Data;
            result.PersonID.ShouldBe(_personID);
        }
    }
}