using System;
using System.Collections.Generic;

namespace Mill_Project.Models
{
    public partial class mis_cube_salesfcst_forecast_customer_currency_rates
    {
        public string forecast_year { get; set; }
        public string gl_crncy_key { get; set; }
        public Nullable<double> rate_from_USD { get; set; }
    }
}
