using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingCheckArr.Core.Models
{
    internal class MovieTVStreamingProvider
    {

        public class Rootobject
        {
            public int id { get; set; }
            public Results results { get; set; }
        }

        public class Results
        {
            public AT AT { get; set; }
            public AU AU { get; set; }
            public BE BE { get; set; }
            public CA CA { get; set; }
            public CH CH { get; set; }
            public DE DE { get; set; }
            public DK DK { get; set; }
            public ES ES { get; set; }
            public FI FI { get; set; }
            public GB GB { get; set; }
            public HK HK { get; set; }
            public IE IE { get; set; }
            public IN IN { get; set; }
            public IT IT { get; set; }
            public KR KR { get; set; }
            public LU LU { get; set; }
            public NL NL { get; set; }
            public NO NO { get; set; }
            public NZ NZ { get; set; }
            public PL PL { get; set; }
            public SE SE { get; set; }
            public US US { get; set; }
            public ZA ZA { get; set; }
        }

        public class AT
        {
            public string link { get; set; }
            public Rent[] rent { get; set; }
            public Buy[] buy { get; set; }
        }

        public class Rent
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class AU
        {
            public string link { get; set; }
            public Buy1[] buy { get; set; }
            public Rent1[] rent { get; set; }
        }

        public class Buy1
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent1
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class BE
        {
            public string link { get; set; }
            public Rent2[] rent { get; set; }
            public Buy2[] buy { get; set; }
        }

        public class Rent2
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy2
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class CA
        {
            public string link { get; set; }
            public Buy3[] buy { get; set; }
            public Rent3[] rent { get; set; }
        }

        public class Buy3
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent3
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class CH
        {
            public string link { get; set; }
            public Buy4[] buy { get; set; }
            public Rent4[] rent { get; set; }
        }

        public class Buy4
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent4
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class DE
        {
            public string link { get; set; }
            public Buy5[] buy { get; set; }
            public Rent5[] rent { get; set; }
        }

        public class Buy5
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent5
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class DK
        {
            public string link { get; set; }
            public Buy6[] buy { get; set; }
            public Rent6[] rent { get; set; }
        }

        public class Buy6
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent6
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class ES
        {
            public string link { get; set; }
            public Rent7[] rent { get; set; }
            public Buy7[] buy { get; set; }
        }

        public class Rent7
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy7
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class FI
        {
            public string link { get; set; }
            public Rent8[] rent { get; set; }
            public Buy8[] buy { get; set; }
        }

        public class Rent8
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy8
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class GB
        {
            public string link { get; set; }
            public Buy9[] buy { get; set; }
            public Rent9[] rent { get; set; }
        }

        public class Buy9
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent9
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class HK
        {
            public string link { get; set; }
            public Buy10[] buy { get; set; }
        }

        public class Buy10
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class IE
        {
            public string link { get; set; }
            public Buy11[] buy { get; set; }
            public Rent10[] rent { get; set; }
        }

        public class Buy11
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent10
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class IN
        {
            public string link { get; set; }
            public Rent11[] rent { get; set; }
            public Buy12[] buy { get; set; }
        }

        public class Rent11
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy12
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class IT
        {
            public string link { get; set; }
            public Buy13[] buy { get; set; }
            public Rent12[] rent { get; set; }
        }

        public class Buy13
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent12
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class KR
        {
            public string link { get; set; }
            public Buy14[] buy { get; set; }
        }

        public class Buy14
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class LU
        {
            public string link { get; set; }
            public Buy15[] buy { get; set; }
            public Rent13[] rent { get; set; }
        }

        public class Buy15
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent13
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class NL
        {
            public string link { get; set; }
            public Flatrate[] flatrate { get; set; }
            public Rent14[] rent { get; set; }
            public Buy16[] buy { get; set; }
        }

        public class Flatrate
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent14
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy16
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class NO
        {
            public string link { get; set; }
            public Rent15[] rent { get; set; }
            public Buy17[] buy { get; set; }
        }

        public class Rent15
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy17
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class NZ
        {
            public string link { get; set; }
            public Rent16[] rent { get; set; }
            public Buy18[] buy { get; set; }
        }

        public class Rent16
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy18
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class PL
        {
            public string link { get; set; }
            public Rent17[] rent { get; set; }
            public Flatrate1[] flatrate { get; set; }
            public Buy19[] buy { get; set; }
        }

        public class Rent17
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Flatrate1
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy19
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class SE
        {
            public string link { get; set; }
            public Rent18[] rent { get; set; }
            public Buy20[] buy { get; set; }
        }

        public class Rent18
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Buy20
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class US
        {
            public string link { get; set; }
            public Buy21[] buy { get; set; }
            public Rent19[] rent { get; set; }
        }

        public class Buy21
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent19
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class ZA
        {
            public string link { get; set; }
            public Buy22[] buy { get; set; }
            public Rent20[] rent { get; set; }
        }

        public class Buy22
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

        public class Rent20
        {
            public string logo_path { get; set; }
            public int provider_id { get; set; }
            public string provider_name { get; set; }
            public int display_priority { get; set; }
        }

    }}
