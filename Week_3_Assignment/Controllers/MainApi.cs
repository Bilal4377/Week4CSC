using Microsoft.AspNetCore.Mvc;

namespace Week_3_Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainApi : ControllerBase
    {
        [HttpPost(Name = "GetWeatherForecast")]

        // Parent list with the name 'parentList' created. Accepts an integer list of any size.

        public ActionResult<List<string>> IntListWork(List<int> parentList)
        {
            // Child list with the name 'childList' created.

            List<string> childList = new List<string>();

            // Variables declared.

            double sum = 0;
            double counter = 0;
            double standardDeviation = 0;
            double sumsquares = 0;

            // Parent list sorted.

            parentList.Sort();

            // Looping through the list to add values from parent list to child list.

            foreach (int i in parentList)
            {
                // Standard Deviation of the child list calculated.

                counter++;
                sum += i;
                sumsquares += i * i;
                standardDeviation = Math.Sqrt((sumsquares - sum * sum / counter) / (counter - 1));

                // If calculation results in a undefined value, message is replaced with the 'NaN' answer. Answers added to child list.

                if (standardDeviation is double.NaN)
                {
                    childList.Add("List too small");
                }
                else
                {
                    childList.Add("Elements: " + counter + " Current Standard Deviation: " + standardDeviation);
                }

                System.Console.WriteLine(LogObject(i));
            }

            int LogObject(int parentList)
            {
                System.Diagnostics.Debug.WriteLine(parentList);
                return parentList;
            }

            // Child list is returned.

            return childList;
        }
    }
}