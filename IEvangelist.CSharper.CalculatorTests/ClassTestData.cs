﻿using System.Collections;
using System.Collections.Generic;


namespace IEvangelist.CSharper.CalculatorTests
{
    public abstract class ClassTestData : IEnumerable<object[]>
    {
        /// <summary>Container for known test data.</summary>
        protected abstract List<object[]> TestData { get; }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<object[]> GetEnumerator() => TestData.GetEnumerator();        
    }
}