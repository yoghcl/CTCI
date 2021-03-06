﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.ArraysAndStrings.Tests
{
    [TestClass()]
    public class ProblemsTests
    {
        [TestMethod()]
        public void HasUniqueCharactersUsingDictionaryTest_WithAllUniqueCharacters()
        {
            var input = "Abc";
            Assert.AreEqual(true, new Problems().HasUniqueCharactersUsingDictionary(input));
        }

        [TestMethod()]
        public void HasUniqueCharactersUsingDictionaryTest_WithSomeDuplicateCharacters()
        {
            var input = "abca";
            Assert.AreEqual(false, new Problems().HasUniqueCharactersUsingDictionary(input));
        }

        [TestMethod()]
        public void HasUniqueCharactersUsingFixedArrayTest_WithAllUniqueCharacters()
        {
            var input = "Abc";
            Assert.AreEqual(true, new Problems().HasUniqueCharactersUsingFixedArray(input));
        }

        [TestMethod()]
        public void HasUniqueCharactersUsingFixedArrayTest_WithSomeDuplicateCharacters()
        {
            var input = "abca";
            Assert.AreEqual(false, new Problems().HasUniqueCharactersUsingFixedArray(input));
        }

        [TestMethod()]
        public void HasUniqueCharactersUsingFixedArrayTest_WithLengthMore128Characters()
        {
            var input = "abcadjkrjwlkjr wrjwrjwkjr rwjrkwejrkjwelkr wjrwrjw rkwjkrjewk rwejrjwekrsdfsdfsjfjsdkfjksd fsfjdskfjksdf sdkfsjfksdfks fjsdlkfjsdkfjs";
            Assert.AreEqual(false, new Problems().HasUniqueCharactersUsingFixedArray(input));
        }

        [TestMethod()]
        public void HasUniqueCharactersUsingHashtableTest_WithAllUniqueCharacters()
        {
            var input = "Abc";
            Assert.AreEqual(true, new Problems().HasUniqueCharactersUsingHashtable(input));
        }

        [TestMethod()]
        public void HasUniqueCharactersUsingHashtableTest_WithSomeDuplicationCharacters()
        {
            var input = "AbcA";
            Assert.AreEqual(false, new Problems().HasUniqueCharactersUsingHashtable(input));
        }
    }
}

