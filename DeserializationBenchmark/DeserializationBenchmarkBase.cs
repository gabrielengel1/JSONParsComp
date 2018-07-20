using BenchmarkDotNet.Attributes;

namespace JSONParsComp.DeserializationBenchmark
{
    public abstract class DeserializationBenchmarkBase : BenchmarkBase
    {
        protected string bigObject, bigArray, realWorldObject;

        [GlobalSetup]
        public void Setup()
        {
            var bigJsonObject = GenerateObjects(3);
            bigObject = bigJsonObject.ToString();

            bigArray = GenerateObjects(3);
            bigObject = bigJsonObject.ToString();

            realWorldObject = @"
                [
                    {
                    ""_id"": ""5b51face4bf21099ed99c556"",
                    ""index"": 0,
                    ""guid"": ""abfa9605-bc98-475a-b90f-6d7160f54e11"",
                    ""isActive"": false,
                    ""balance"": ""$2,982.97"",
                    ""picture"": ""http://placehold.it/32x32"",
                    ""age"": 26,
                    ""eyeColor"": ""brown"",
                    ""name"": {
                    ""first"": ""Gwendolyn"",
                    ""last"": ""Davis""
                    },
                    ""company"": ""VANTAGE"",
                    ""email"": ""gwendolyn.davis@vantage.org"",
                    ""phone"": ""+1 (852) 420-2535"",
                    ""address"": ""884 Balfour Place, Jenkinsville, New Jersey, 2020"",
                    ""about"": ""Officia consectetur labore consequat culpa duis sit sint aute anim id sit nisi et cupidatat. Cillum cupidatat Lorem aliquip laboris. Aliqua enim aliquip sint ex enim amet. Et mollit aliquip culpa non irure reprehenderit duis aliquip dolore occaecat dolor do esse. Lorem enim duis culpa adipisicing Lorem aliqua labore non aliqua labore nostrud qui laborum Lorem."",
                    ""registered"": ""Monday, November 14, 2016 8:56 PM"",
                    ""latitude"": ""87.980597"",
                    ""longitude"": ""-165.147503"",
                    ""tags"": [
                    ""laborum"",
                    ""elit"",
                    ""labore"",
                    ""voluptate"",
                    ""laboris""
                    ],
                    ""range"": [
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9
                    ],
                    ""friends"": [
                    {
                        ""id"": 0,
                        ""name"": ""Kerry Rose""
                    },
                    {
                        ""id"": 1,
                        ""name"": ""West Branch""
                    },
                    {
                        ""id"": 2,
                        ""name"": ""Dorthy Mcintyre""
                    }
                    ],
                    ""greeting"": ""Hello, Gwendolyn! You have 10 unread messages."",
                    ""favoriteFruit"": ""apple""
                },
                {
                    ""_id"": ""5b51face966e7465fc36ee64"",
                    ""index"": 1,
                    ""guid"": ""ad2ae99f-7dd1-4c8f-91d2-ff46fffb913e"",
                    ""isActive"": false,
                    ""balance"": ""$2,570.66"",
                    ""picture"": ""http://placehold.it/32x32"",
                    ""age"": 24,
                    ""eyeColor"": ""brown"",
                    ""name"": {
                    ""first"": ""Webb"",
                    ""last"": ""Forbes""
                    },
                    ""company"": ""XOGGLE"",
                    ""email"": ""webb.forbes@xoggle.com"",
                    ""phone"": ""+1 (901) 455-3213"",
                    ""address"": ""388 Rogers Avenue, Wintersburg, Federated States Of Micronesia, 4195"",
                    ""about"": ""Amet dolore sunt et anim. Ex voluptate velit irure esse labore qui velit aute. Minim tempor esse veniam non anim velit cupidatat cupidatat. Ex reprehenderit eu aliquip culpa esse fugiat commodo sunt consequat consequat. Ut nisi veniam dolor ullamco duis in dolore magna non amet."",
                    ""registered"": ""Wednesday, November 15, 2017 8:16 PM"",
                    ""latitude"": ""36.789821"",
                    ""longitude"": ""-105.018651"",
                    ""tags"": [
                    ""pariatur"",
                    ""qui"",
                    ""sint"",
                    ""mollit"",
                    ""ullamco""
                    ],
                    ""range"": [
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9
                    ],
                    ""friends"": [
                    {
                        ""id"": 0,
                        ""name"": ""Lavonne Petty""
                    },
                    {
                        ""id"": 1,
                        ""name"": ""Bates Ortiz""
                    },
                    {
                        ""id"": 2,
                        ""name"": ""Callie Bray""
                    }
                    ],
                    ""greeting"": ""Hello, Webb! You have 9 unread messages."",
                    ""favoriteFruit"": ""apple""
                },
                {
                    ""_id"": ""5b51face7c54092b64323598"",
                    ""index"": 2,
                    ""guid"": ""0fed9689-b5d6-4018-82cb-9ffd346d8660"",
                    ""isActive"": false,
                    ""balance"": ""$3,453.36"",
                    ""picture"": ""http://placehold.it/32x32"",
                    ""age"": 30,
                    ""eyeColor"": ""blue"",
                    ""name"": {
                    ""first"": ""Rosa"",
                    ""last"": ""Donovan""
                    },
                    ""company"": ""AQUAZURE"",
                    ""email"": ""rosa.donovan@aquazure.co.uk"",
                    ""phone"": ""+1 (860) 487-2056"",
                    ""address"": ""890 Norwood Avenue, Statenville, American Samoa, 2090"",
                    ""about"": ""Laboris fugiat ad ad officia consequat non non duis non enim do veniam nisi. Ipsum eu fugiat irure aliqua duis occaecat sint. Nulla quis sint laborum nostrud id excepteur in consectetur ad. Irure esse consequat quis aute ipsum minim qui Lorem incididunt. Ipsum aliquip pariatur sint cillum aliquip consequat laboris cupidatat do sunt."",
                    ""registered"": ""Tuesday, May 16, 2017 5:48 AM"",
                    ""latitude"": ""-12.32323"",
                    ""longitude"": ""-64.912566"",
                    ""tags"": [
                    ""nisi"",
                    ""culpa"",
                    ""deserunt"",
                    ""duis"",
                    ""dolore""
                    ],
                    ""range"": [
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9
                    ],
                    ""friends"": [
                    {
                        ""id"": 0,
                        ""name"": ""Wilkinson Patrick""
                    },
                    {
                        ""id"": 1,
                        ""name"": ""Chandra Serrano""
                    },
                    {
                        ""id"": 2,
                        ""name"": ""Bartlett Larsen""
                    }
                    ],
                    ""greeting"": ""Hello, Rosa! You have 5 unread messages."",
                    ""favoriteFruit"": ""strawberry""
                },
                {
                    ""_id"": ""5b51face003eba0008a7cef4"",
                    ""index"": 3,
                    ""guid"": ""ae621c09-6be7-49b8-b2fe-9c5fb4e0f4cb"",
                    ""isActive"": true,
                    ""balance"": ""$1,997.50"",
                    ""picture"": ""http://placehold.it/32x32"",
                    ""age"": 22,
                    ""eyeColor"": ""brown"",
                    ""name"": {
                    ""first"": ""Araceli"",
                    ""last"": ""House""
                    },
                    ""company"": ""TOURMANIA"",
                    ""email"": ""araceli.house@tourmania.info"",
                    ""phone"": ""+1 (885) 507-3377"",
                    ""address"": ""972 Hale Avenue, Beaverdale, Hawaii, 329"",
                    ""about"": ""Mollit est reprehenderit mollit fugiat ipsum deserunt excepteur esse irure ea. Do pariatur laboris laborum elit pariatur qui velit sit culpa ullamco aute aliqua deserunt. Culpa officia sit et qui reprehenderit ex ut eiusmod quis veniam voluptate exercitation magna exercitation. Esse non reprehenderit irure anim duis non sint ea esse labore minim nostrud cillum. Sint esse ad sit sit consequat. Ipsum velit do anim eu."",
                    ""registered"": ""Thursday, June 30, 2016 2:53 PM"",
                    ""latitude"": ""5.392906"",
                    ""longitude"": ""139.844162"",
                    ""tags"": [
                    ""ipsum"",
                    ""in"",
                    ""irure"",
                    ""adipisicing"",
                    ""duis""
                    ],
                    ""range"": [
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9
                    ],
                    ""friends"": [
                    {
                        ""id"": 0,
                        ""name"": ""Warner Lawson""
                    },
                    {
                        ""id"": 1,
                        ""name"": ""Emily Rasmussen""
                    },
                    {
                        ""id"": 2,
                        ""name"": ""Fulton Whitfield""
                    }
                    ],
                    ""greeting"": ""Hello, Araceli! You have 8 unread messages."",
                    ""favoriteFruit"": ""apple""
                },
                {
                    ""_id"": ""5b51facee2ae0cba6b25b99d"",
                    ""index"": 4,
                    ""guid"": ""a2665db4-34f3-4967-829f-3e23dc690bb3"",
                    ""isActive"": false,
                    ""balance"": ""$2,122.50"",
                    ""picture"": ""http://placehold.it/32x32"",
                    ""age"": 33,
                    ""eyeColor"": ""green"",
                    ""name"": {
                    ""first"": ""Camille"",
                    ""last"": ""Franco""
                    },
                    ""company"": ""GEEKUS"",
                    ""email"": ""camille.franco@geekus.net"",
                    ""phone"": ""+1 (975) 567-2502"",
                    ""address"": ""513 Montauk Court, Lutsen, North Carolina, 6919"",
                    ""about"": ""Eiusmod velit consectetur ea amet est eu reprehenderit velit. Incididunt do cupidatat ex dolore ullamco. Incididunt aliquip incididunt nostrud dolore irure aliqua magna dolor pariatur eu proident occaecat. Qui voluptate nulla culpa ex amet velit ipsum est reprehenderit. Mollit consectetur dolor aliqua Lorem exercitation incididunt. Tempor tempor qui fugiat dolor."",
                    ""registered"": ""Tuesday, March 31, 2015 11:48 AM"",
                    ""latitude"": ""32.758531"",
                    ""longitude"": ""128.965524"",
                    ""tags"": [
                    ""est"",
                    ""occaecat"",
                    ""ut"",
                    ""dolor"",
                    ""consectetur""
                    ],
                    ""range"": [
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9
                    ],
                    ""friends"": [
                    {
                        ""id"": 0,
                        ""name"": ""Marjorie Chang""
                    },
                    {
                        ""id"": 1,
                        ""name"": ""Norris Fuller""
                    },
                    {
                        ""id"": 2,
                        ""name"": ""John Vincent""
                    }
                    ],
                    ""greeting"": ""Hello, Camille! You have 8 unread messages."",
                    ""favoriteFruit"": ""strawberry""
                },
                {
                    ""_id"": ""5b51face3a48b8da064b16ab"",
                    ""index"": 5,
                    ""guid"": ""0244dfe4-d430-4d0e-9802-5f90f6006ce7"",
                    ""isActive"": true,
                    ""balance"": ""$2,038.44"",
                    ""picture"": ""http://placehold.it/32x32"",
                    ""age"": 27,
                    ""eyeColor"": ""green"",
                    ""name"": {
                    ""first"": ""Mcmillan"",
                    ""last"": ""Solis""
                    },
                    ""company"": ""KOFFEE"",
                    ""email"": ""mcmillan.solis@koffee.name"",
                    ""phone"": ""+1 (932) 438-3537"",
                    ""address"": ""116 Seaview Avenue, Mulino, Virginia, 6283"",
                    ""about"": ""Velit voluptate elit et sit veniam elit labore incididunt aute est veniam ex nostrud. Culpa ex proident Lorem non irure pariatur. Duis enim commodo quis enim occaecat id exercitation consequat labore enim ex laboris ullamco. Cupidatat sunt veniam ex veniam do deserunt aute. Cillum deserunt ex nulla sint et ad ad adipisicing. Eu sunt velit consequat commodo cupidatat."",
                    ""registered"": ""Tuesday, November 22, 2016 6:53 AM"",
                    ""latitude"": ""-1.265508"",
                    ""longitude"": ""-22.607486"",
                    ""tags"": [
                    ""do"",
                    ""nisi"",
                    ""quis"",
                    ""eu"",
                    ""ea""
                    ],
                    ""range"": [
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9
                    ],
                    ""friends"": [
                    {
                        ""id"": 0,
                        ""name"": ""Richard Daniel""
                    },
                    {
                        ""id"": 1,
                        ""name"": ""White Hensley""
                    },
                    {
                        ""id"": 2,
                        ""name"": ""Kathleen Stephenson""
                    }
                    ],
                    ""greeting"": ""Hello, Mcmillan! You have 6 unread messages."",
                    ""favoriteFruit"": ""apple""
                },
                {
                    ""_id"": ""5b51faceeec8246967060c18"",
                    ""index"": 6,
                    ""guid"": ""94a59bdb-7b3a-4a05-95b5-348a9c9ed96d"",
                    ""isActive"": true,
                    ""balance"": ""$2,060.79"",
                    ""picture"": ""http://placehold.it/32x32"",
                    ""age"": 30,
                    ""eyeColor"": ""green"",
                    ""name"": {
                    ""first"": ""Deanne"",
                    ""last"": ""Alvarado""
                    },
                    ""company"": ""LIMAGE"",
                    ""email"": ""deanne.alvarado@limage.me"",
                    ""phone"": ""+1 (986) 559-2665"",
                    ""address"": ""846 Lott Avenue, Wyoming, Alaska, 2324"",
                    ""about"": ""Sit aliquip ea nostrud nisi occaecat. Ullamco consectetur sit ad elit duis. Mollit veniam commodo incididunt labore excepteur reprehenderit velit. Excepteur aliqua consectetur do ex aliquip deserunt anim aliqua ad est. Eiusmod mollit proident consectetur cupidatat amet ea id. Et sint reprehenderit proident mollit consectetur. Exercitation aliqua aliqua do ad tempor consequat nisi sint tempor cillum consectetur."",
                    ""registered"": ""Sunday, November 8, 2015 3:05 AM"",
                    ""latitude"": ""67.32905"",
                    ""longitude"": ""-118.560707"",
                    ""tags"": [
                    ""esse"",
                    ""eiusmod"",
                    ""irure"",
                    ""magna"",
                    ""enim""
                    ],
                    ""range"": [
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9
                    ],
                    ""friends"": [
                    {
                        ""id"": 0,
                        ""name"": ""Shaffer Bolton""
                    },
                    {
                        ""id"": 1,
                        ""name"": ""Simpson Rodgers""
                    },
                    {
                        ""id"": 2,
                        ""name"": ""Jennifer Gomez""
                    }
                    ],
                    ""greeting"": ""Hello, Deanne! You have 5 unread messages."",
                    ""favoriteFruit"": ""strawberry""
                },
                {
                    ""_id"": ""5b51face59bd1f03e41a1741"",
                    ""index"": 7,
                    ""guid"": ""be83b4d5-0cc7-4646-93ba-5dd88f4249de"",
                    ""isActive"": false,
                    ""balance"": ""$2,392.50"",
                    ""picture"": ""http://placehold.it/32x32"",
                    ""age"": 38,
                    ""eyeColor"": ""blue"",
                    ""name"": {
                    ""first"": ""Hendricks"",
                    ""last"": ""Browning""
                    },
                    ""company"": ""KENGEN"",
                    ""email"": ""hendricks.browning@kengen.ca"",
                    ""phone"": ""+1 (935) 471-2666"",
                    ""address"": ""907 Fleet Street, Lopezo, Palau, 5867"",
                    ""about"": ""Enim sint ut duis esse magna culpa ad. Esse culpa occaecat qui minim exercitation ex nisi anim proident et incididunt. Ad culpa enim nostrud tempor incididunt incididunt pariatur velit do non ullamco laboris aliquip duis. Ullamco aliqua pariatur amet dolor commodo ut aute velit cillum esse duis. Reprehenderit eu fugiat nostrud nostrud non duis tempor."",
                    ""registered"": ""Thursday, April 5, 2018 3:55 AM"",
                    ""latitude"": ""23.660903"",
                    ""longitude"": ""20.106811"",
                    ""tags"": [
                    ""culpa"",
                    ""dolore"",
                    ""fugiat"",
                    ""est"",
                    ""cillum""
                    ],
                    ""range"": [
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9
                    ],
                    ""friends"": [
                    {
                        ""id"": 0,
                        ""name"": ""England Pate""
                    },
                    {
                        ""id"": 1,
                        ""name"": ""Noelle Downs""
                    },
                    {
                        ""id"": 2,
                        ""name"": ""Lelia Holcomb""
                    }
                    ],
                    ""greeting"": ""Hello, Hendricks! You have 10 unread messages."",
                    ""favoriteFruit"": ""banana""
                },
                {
                    ""_id"": ""5b51face298dd84ce206c52b"",
                    ""index"": 8,
                    ""guid"": ""e8bfecf5-19fc-45ea-bd58-eb0cfcc3c4f4"",
                    ""isActive"": false,
                    ""balance"": ""$3,742.10"",
                    ""picture"": ""http://placehold.it/32x32"",
                    ""age"": 23,
                    ""eyeColor"": ""green"",
                    ""name"": {
                    ""first"": ""Hogan"",
                    ""last"": ""Weber""
                    },
                    ""company"": ""NETBOOK"",
                    ""email"": ""hogan.weber@netbook.biz"",
                    ""phone"": ""+1 (848) 408-2882"",
                    ""address"": ""717 Canal Avenue, Zortman, Minnesota, 4086"",
                    ""about"": ""Ut nostrud ipsum in quis adipisicing proident aliquip consectetur dolore ea sint do. Do do ex sunt ullamco anim ea duis ipsum quis. Id mollit sunt excepteur ex elit Lorem ad dolor cupidatat commodo. Labore ipsum do veniam ea consectetur nulla irure ut."",
                    ""registered"": ""Friday, June 8, 2018 12:49 AM"",
                    ""latitude"": ""11.043845"",
                    ""longitude"": ""45.608028"",
                    ""tags"": [
                    ""magna"",
                    ""non"",
                    ""laborum"",
                    ""in"",
                    ""mollit""
                    ],
                    ""range"": [
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9
                    ],
                    ""friends"": [
                    {
                        ""id"": 0,
                        ""name"": ""Jami Landry""
                    },
                    {
                        ""id"": 1,
                        ""name"": ""Norma Cortez""
                    },
                    {
                        ""id"": 2,
                        ""name"": ""Richards Jackson""
                    }
                    ],
                    ""greeting"": ""Hello, Hogan! You have 8 unread messages."",
                    ""favoriteFruit"": ""banana""
                    }
                ]
            ";
        }

        public abstract void DeserializeBigObject();
        public abstract void DeserializeBigArray();
        public abstract void DeserializeRealWorldObject();
    }
}