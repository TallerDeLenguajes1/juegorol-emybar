using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;


namespace juego
{
     // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Asteroide
        {
            [JsonPropertyName("rms")]
            public double Rms { get; set; }

            [JsonPropertyName("epoch")]
            public string Epoch { get; set; }

            [JsonPropertyName("readable_des")]
            public string ReadableDes { get; set; }

            [JsonPropertyName("H")]
            public double H { get; set; }

            [JsonPropertyName("num_obs")]
            public int NumObs { get; set; }

            [JsonPropertyName("ref")]
            public string Ref { get; set; }

            [JsonPropertyName("G")]
            public double G { get; set; }

            [JsonPropertyName("last_obs")]
            public string LastObs { get; set; }

            [JsonPropertyName("comp")]
            public string Comp { get; set; }

            [JsonPropertyName("M")]
            public double M { get; set; }

            [JsonPropertyName("U")]
            public string U { get; set; }

            [JsonPropertyName("e")]
            public double E { get; set; }

            [JsonPropertyName("a")]
            public double A { get; set; }

            [JsonPropertyName("om")]
            public double Om { get; set; }

            [JsonPropertyName("pert_p")]
            public string PertP { get; set; }

            [JsonPropertyName("d")]
            public double D { get; set; }

            [JsonPropertyName("i")]
            public double I { get; set; }

            [JsonPropertyName("des")]
            public string Des { get; set; }

            [JsonPropertyName("flags")]
            public string Flags { get; set; }

            [JsonPropertyName("num_opp")]
            public int NumOpp { get; set; }

            [JsonPropertyName("w")]
            public double W { get; set; }

            [JsonPropertyName("pert_c")]
            public string PertC { get; set; }
        }


    }

