﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Button_Executer;

namespace ButtonTests
{
    [TestClass]
    public class UnitTest1
    {
        // Environment.ExpandEnvironmentVariables("%userprofile%\\Documents\\buttons.xml")
        [TestMethod]
        public void TestLabelTooLong()
        {
            ButtonValidator buttonValidator = new ButtonValidator();
            bool status = buttonValidator.validateButtons(Environment.ExpandEnvironmentVariables("%userprofile%\\Documents\\buttons_too_long.xml"));
            Assert.IsFalse(status);
        }
        [TestMethod]
        public void TestInvalidType()
        {
            ButtonValidator buttonValidator = new ButtonValidator();
            bool status = buttonValidator.validateButtons(Environment.ExpandEnvironmentVariables("%userprofile%\\Documents\\buttons_invalid_type.xml"));
            Assert.IsFalse(status);
        }
        [TestMethod]
        public void TestInvalidLink()
        {
            ButtonValidator buttonValidator = new ButtonValidator();
            bool status = buttonValidator.validateButtons(Environment.ExpandEnvironmentVariables("%userprofile%\\Documents\\buttons_invalid_link.xml"));
            Assert.IsFalse(status);
        }
    }
}
