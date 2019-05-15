﻿using System;

namespace Kata005.Models
{
    public class Maybe<T> where T : class
    {
        private readonly T value;

        public Maybe(T someValue)
        {
            if (someValue == null)
                throw new ArgumentNullException(nameof(someValue));
            this.value = someValue;
        }

        private Maybe() { }

        public Maybe<TO> Bind<TO>(Func<T, Maybe<TO>> func) where TO : class
        {
            return value != null ? func(value) : Maybe<TO>.None();
        }

        public static Maybe<T> None() => new Maybe<T>();
    }
    public static class MaybeExtensions
    {
        public static Maybe<T> Return<T>(this T value) where T : class
        {
            return value != null ? new Maybe<T>(value) : Maybe<T>.None();
        }
    }
}
