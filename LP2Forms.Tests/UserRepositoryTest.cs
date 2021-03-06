// <copyright file="UserRepositoryTest.cs">Copyright ©  2017</copyright>
using System;
using LP2Forms.Contexts;
using LP2Forms.Repositories;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LP2Forms.Repositories.Tests
{
    /// <summary>This class contains parameterized unit tests for UserRepository</summary>
    [PexClass(typeof(UserRepository))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UserRepositoryTest
    {
        /// <summary>Test stub for .ctor(IUserContext)</summary>
        [PexMethod]
        public UserRepository ConstructorTest(IUserContext context)
        {
            UserRepository target = new UserRepository(context);
            return target;
            // TODO: add assertions to method UserRepositoryTest.ConstructorTest(IUserContext)
        }
    }
}
