
public static TourBaseZEntities context;

        public static TourBaseZEntities GetContext()
        {
            if (context == null)
                context = new TourBaseZEntities();
            return context;
        }
