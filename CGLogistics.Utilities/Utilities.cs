using System;
namespace CGLogistics.Utilities
{
    public static class Utilities
    {
        public static void Logger(string str) {
            Console.Write(str);
        }

        public static void Mee(string str)
        {
            Console.WriteLine(str);
        }
        public static void Seed(){

            #region seed
            /*public static void AddMultipleCustomers()
            {
                GlobalConfig.AddInstance();
                ICustomerRepository CustomerInstance = GlobalConfig.CustomerInstance;
                List<Customer> customer = new List<Customer>();
                customer.Add(new Customer
                {
                    FirstName = "Dwayne",
                    SecondName = "Johnson",
                    OtherName = "TheRock",
                    Email = "rock@gmail.com",
                    Password = "1234"
                });
                customer.Add(new Customer
                {
                    FirstName = "Arethe",
                    SecondName = "Franklin",
                    OtherName = "thevoice",
                    Email = "arethe@gmail.com",
                    Password = "1234"
                });

                customer.Add(new Customer
                {
                    FirstName = "Lebron",
                    SecondName = "James",
                    OtherName = "King",
                    Email = "23@gmail.com",
                    Password = "1234"
                });

                customer.Add(new Customer
                {
                    FirstName = "Seean",
                    SecondName = "Combs",
                    OtherName = "diddy",
                    Email = "diddy@gmail.com",
                    Password = "4321"
                });

                customer.Add(new Customer
                {
                    FirstName = "Clint",
                    SecondName = "Eastword",
                    OtherName = "thevision",
                    Email = "vision@gmail.com",
                    Password = "1534"
                });

                customer.Add(new Customer
                {
                    FirstName = "Ricky",
                    SecondName = "Martin",
                    OtherName = "",
                    Email = "marting@gmail.com",
                    Password = "1234"
                });

                customer.Add(new Customer
                {
                    FirstName = "Anthony",
                    SecondName = "Joshua",
                    OtherName = "aj",
                    Email = "aj@gmail.com",
                    Password = "4522"
                });

                customer.Add(new Customer
                {
                    FirstName = "Eazy",
                    SecondName = "E",
                    OtherName = "",
                    Email = "e@gmail.com",
                    Password = "1234"
                });

                customer.Add(new Customer
                {
                    FirstName = "Hype",
                    SecondName = "Williams",
                    OtherName = "creative",
                    Email = "hype@gmail.com",
                    Password = "5678"
                });

                foreach (var item in customer)
                {
                    CustomerInstance.Add(item);
                }
            }
            #endregion
            public static void AddCategory()
            {
                GlobalConfig.AddInstance();
                ICustomerRepository CustomerInstance = GlobalConfig.CustomerInstance;
                List<Category> categories = new List<Category>();
                categories.Add(new Category
                {
                    CategoryName = "Food and Beverage"
                });
                categories.Add(new Category
                {
                    CategoryName = "Electric Aplliance"
                });
                categories.Add(new Category
                {
                    CategoryName = "Sport Equipment"
                });
                categories.Add(new Category
                {
                    CategoryName = "Office Stationary"
                });
                categories.Add(new Category
                {
                    CategoryName = "Others"
                });

                foreach (var category in categories)
                {
                    CustomerInstance.Add(category);
                }



            }
            public static void AddMultipleCustomers()
        {
            GlobalConfig.AddInstance();
            ICustomerRepository CustomerInstance = GlobalConfig.CustomerInstance;
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            orderDetails.Add(new OrderDetails
            {
                DateOfOrder = DateTime.Today,
                DateOfReceipt = new DateTime(2021, 05, 10),
                OrderId = 12,
                ShipperId = 1,
                SupplierId = 5
            });

            orderDetails.Add(new OrderDetails
            {
                DateOfOrder = DateTime.Today,
                DateOfReceipt = new DateTime(2021, 05, 10),
                OrderId = 10,
                ShipperId = 2,
                SupplierId = 3
            });

            orderDetails.Add(new OrderDetails
            {
                DateOfOrder = DateTime.Today,
                DateOfReceipt = new DateTime(2021, 05, 10),
                OrderId = 7,
                ShipperId = 6,
                SupplierId = 6
            });

            orderDetails.Add(new OrderDetails
            {
                DateOfOrder = DateTime.Today,
                DateOfReceipt = new DateTime(2021, 05, 10),
                OrderId = 12,
                ShipperId = 2,
                SupplierId = 2
            });

            orderDetails.Add(new OrderDetails
            {
                DateOfOrder = DateTime.Today,
                DateOfReceipt = new DateTime(2021, 05, 10),
                OrderId = 4,
                ShipperId = 2,
                SupplierId = 5
            });

            orderDetails.Add(new OrderDetails
            {
                DateOfOrder = DateTime.Today,
                DateOfReceipt = new DateTime(2021, 05, 10),
                OrderId = 15,
                ShipperId = 7,
                SupplierId = 1
            });

            foreach (var orderDetail in orderDetails)
            {
                CustomerInstance.Add(orderDetail);
            }
        }

            public static void AddCustomerAddress()
            {

                GlobalConfig.AddInstance();
                ICustomerRepository CustomerInstance = GlobalConfig.CustomerInstance;
                List<CustomersAddress> customersAddresses = new List<CustomersAddress>();

                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 1,
                    CustomerId = 1,
                    Address = "Third Avenu Hillstation hotel",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 2,
                    CustomerId = 2,
                    Address = "Stadium block 34",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 3,
                    CustomerId = 3,
                    Address = "Goverment House ",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 4,
                    CustomerId = 4,
                    Address = "State Lowcost",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 5,
                    CustomerId = 5,
                    Address = "Fed Lowcost",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 6,
                    CustomerId = 6,
                    Address = "23 Adeleke Estate",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 7,
                    CustomerId = 7,
                    Address = "Millionairs quaters b45",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 8,
                    CustomerId = 8,
                    Address = "block 45 staff quaters",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 9,
                    CustomerId = 9,
                    Address = "City of angels dawn 45",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 10,
                    CustomerId = 10,
                    Address = "No. 5 Jewel Estata",
                });

                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 25,
                    CustomerId = 11,
                    Address = "b.45 palmGroove",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 25,
                    CustomerId = 8,
                    Address = "chill street Banana island",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 25,
                    CustomerId = 8,
                    Address = "st. paul street mogodo",
                });
                customersAddresses.Add(new CustomersAddress
                {
                    CountryId = 156,
                    StateId = 23,
                    CustomerId = 10,
                    Address = "No. 5 Tudun wada",
                });

                foreach (var address in customersAddresses)
                {
                    CustomerInstance.Add(address);
                }

            }

            public static void AddMultipleSuppliers()
            {
                GlobalConfig.AddInstance();
                ICustomerRepository CustomerInstance = GlobalConfig.CustomerInstance;
                List<Supplier> suppliers = new List<Supplier>();
                suppliers.Add(new Supplier
                {
                    *//*       public int Id { get; set; }
            public string SupplierName { get; set; }
            public string SupplierRegNumber { get; set; }
            public string SupplierEmail { get; set; }
            public string SupplierPassword { get; set; }
            public List<Customer> Customers { get; set; }
            public int costumerId { get; set; }*//*

                });

                foreach (var customer in suppliers)
                {
                    CustomerInstance.Add(customer);
                }


            }

            public static void AddPhoneNumbers()
            {
                GlobalConfig.AddInstance();
                ICustomerRepository CustomerInstance = GlobalConfig.CustomerInstance;
                List<CustomersPhoneNumber> customersPhoneNumbers = new List<CustomersPhoneNumber>();
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0703192342",
                    CustomerId = 1
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0912324342",
                    CustomerId = 2
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0812345432",
                    CustomerId = 3
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0904543345",
                    CustomerId = 4
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0703192342",
                    CustomerId = 5
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0804342321",
                    CustomerId = 6
                });


                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0908423762",
                    CustomerId = 7
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0812323244",
                    CustomerId = 8
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0914343733",
                    CustomerId = 9
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "07043236232",
                    CustomerId = 10
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "07031923427",
                    CustomerId = 11
                });

                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "0703432423",
                    CustomerId = 12
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "08045934322",
                    CustomerId = 13
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "09023424322",
                    CustomerId = 14
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "09123232245",
                    CustomerId = 15
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "07099342223",
                    CustomerId = 16
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "07045342221",
                    CustomerId = 17
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "090887327224",
                    CustomerId = 18
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "08134343563",
                    CustomerId = 19
                });
                customersPhoneNumbers.Add(new CustomersPhoneNumber
                {
                    CountryId = 156,
                    Number = "080657324231",
                    CustomerId = 20
                });

                foreach (var number in customersPhoneNumbers)
                {
                    CustomerInstance.Add(number);
                }

            }

            public static void UpdateCustomer()
            {
                List<Customer> customers = new List<Customer>();
                customers = context.Customer.ToList();
                //var customer = context.Customer.Find(2);
                int i = 0;
                foreach (var customer in customers)
                {
                    i++;
                    *//*customer.OrderId = Guid.NewGuid().ToString();*//*
                    customer.OrderId = i.ToString();
                    context.SaveChanges();
                }

            }

            public static void AddOrderDetails()
            {
                *//* public int Id { get; set; }
            public string DateOfOrder { get; set; }
            public string DateOfReceipt { get; set; }
            public int OrderId { get; set; }*//*
            }

            public static void AddOrder()
            {
                GlobalConfig.AddInstance();
                ICustomerRepository CustomerInstance = GlobalConfig.CustomerInstance;
                List<Order> orders = new List<Order>();
                orders.Add(new Order
                {
                    Quantity = 1,
                    CustomerId = 1,
                    ProductId = 1
                });
                orders.Add(new Order
                {
                    Quantity = 2,
                    CustomerId = 2,
                    ProductId = 3
                });
                orders.Add(new Order
                {
                    Quantity = 2,
                    CustomerId = 4,
                    ProductId = 5
                });
                orders.Add(new Order
                {
                    Quantity = 1,
                    CustomerId = 5,
                    ProductId = 2
                });
                orders.Add(new Order
                {
                    Quantity = 4,
                    CustomerId = 6,
                    ProductId = 5
                });



                orders.Add(new Order
                {
                    Quantity = 4,
                    CustomerId = 6,
                    ProductId = 5
                });

                orders.Add(new Order
                {
                    Quantity = 1,
                    CustomerId = 7,
                    ProductId = 5
                }); orders.Add(new Order
                {
                    Quantity = 1,
                    CustomerId = 4,
                    ProductId = 3
                }); orders.Add(new Order
                {
                    Quantity = 7,
                    CustomerId = 10,
                    ProductId = 1
                }); orders.Add(new Order
                {
                    Quantity = 1,
                    CustomerId = 4,
                    ProductId = 15
                }); orders.Add(new Order
                {
                    Quantity = 2,
                    CustomerId = 6,
                    ProductId = 5
                }); orders.Add(new Order
                {
                    Quantity = 1,
                    CustomerId = 15,
                    ProductId = 14
                }); orders.Add(new Order
                {
                    Quantity = 3,
                    CustomerId = 16,
                    ProductId = 12
                }); orders.Add(new Order
                {
                    Quantity = 1,
                    CustomerId = 19,
                    ProductId = 9
                });

                foreach (var order in orders)
                {
                    CustomerInstance.Add(order);
                }

            }
            public static void AddProduct()
            {
                GlobalConfig.AddInstance();
                ICustomerRepository CustomerInstance = GlobalConfig.CustomerInstance;
                List<Product> products = new List<Product>();

                products.Add(new Product
                {
                    ProductName = "Yeezy Truck",
                    Price = 3000000,
                    Description = "Can climb mountain kilmajaro",
                    DiscountPrice = 100000,
                    CategoryId = 5
                });

                products.Add(new Product
                {
                    ProductName = "Slippers",
                    Price = 10000,
                    Description = "Slipper that will make you moonwalk",
                    DiscountPrice = 500,
                    CategoryId = 3
                });

                products.Add(new Product
                {
                    ProductName = "Vionic Headphone",
                    Price = 20000,
                    Description = "Protect your eyes againgst rays",
                    DiscountPrice = 2000,
                    CategoryId = 4
                });

                products.Add(new Product
                {
                    ProductName = "Designer T-Shirt",
                    Price = 5000,
                    Description = "Complement you swag",
                    DiscountPrice = 2500,
                    CategoryId = 7
                });

                products.Add(new Product
                {
                    ProductName = "Iphone 12",
                    Price = 50000,
                    Description = "The only phone in the room",
                    DiscountPrice = 350000,
                    CategoryId = 4
                });


                foreach (var product in products)
                {
                    CustomerInstance.Add(product);
                }


                *//*
                 ,[ProductName]
                 ,[Price]
                 ,[Description]
                 ,[OrderId]
                 ,[CategoryId
                ]*/

            /*  Id CategoryName
            3   Food and Beverage
            4   Electric Aplliance
            5   Sport Equipment
            6   Office Stationary
            7   Others*//*
        }
        public static void UpdateProduct()
        {
            List<Product> products = new List<Product>();
            products = context.Product.ToList();
            var product = context.Product.Find(5);
            product.DiscountPrice = 100000;
            product.Price = 500000;
            context.SaveChanges();
            *//*int i = 0;
            foreach (var product in products)
            {
                i++;
                product.Description = i.ToString();
                context.SaveChanges();
            }*//*

        }*/

            #endregion

        }

        public static void Logger()
        {
            throw new NotImplementedException();
        }
    }
}
