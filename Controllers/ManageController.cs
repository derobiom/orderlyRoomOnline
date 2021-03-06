﻿// <copyright file="ManageController.cs" company="Stormpath, Inc.">
// Copyright (c) 2016 Stormpath, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stormpath.SDK.Account;
using Stormpath.SDK.Client;

namespace or.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        private readonly IClient stormpathClient;
        private readonly IAccount stormpathAccount;

        public ManageController(IClient stormpathClient, IAccount stormpathAccount)
        {
            // Stormpath request objects injected via DI
            this.stormpathClient = stormpathClient;
            this.stormpathAccount = stormpathAccount;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
