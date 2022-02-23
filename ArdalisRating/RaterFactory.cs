using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(RatingEngine ratingEngine, Policy policy)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                        new object[] { ratingEngine, ratingEngine.Logger });
            }
            catch
            {
                return null;
            }
        }
    }
}
