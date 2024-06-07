using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Assignment2_4
    {
        private Movie[] Movies = new Movie[5]; 
        private int MovieCount = 0;
        public void MovieRecomendationSystem()
        {
            while (true)
            {
                Console.WriteLine("1. Add a Movie");
                Console.WriteLine("2. Search a Movie");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose a number");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddMovie();
                        break;
                    case 2:
                        SearchMovie();
                        break;

                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }

        }

        public void AddMovie()
        {
            Console.Write("Enter the title of the movie: ");
            string title = Console.ReadLine();
            Console.Write("Enter the genre of the movie: ");
            string genre = Console.ReadLine();

            if (MovieCount < Movies.Length)
            {
                Movies[MovieCount] = new Movie(title, genre);
                MovieCount++;
                Console.WriteLine("Movie added successfully!");
            }
            else
            {
                Console.WriteLine("Array is full. Unable to add a new movie.");
            }
        }

        public void SearchMovie()
        {
            if (MovieCount == 0)
            {
                Console.WriteLine("No movies found. Please add movies first.");
                return;
            }
            Console.Write("Enter the title of the movie to search: ");
            string searchTitle = Console.ReadLine();

            bool found = false;
            for( int i=0; i<MovieCount; i++)
            {
                Movies[i].Title = searchTitle;
                Console.Write($"Movie Found!. title : {Movies[i].Title} and Genre: {Movies[i].Genre}");
                found = true;
                break;
            }
            if(!found)
            {
                Console.WriteLine("Movie is not found");
            }

        }
    }

    class Movie
    {
        public String Title { get; set; }
        public string Genre {  get; set; }

        public Movie(String  Title, String Genre)
        {
            this.Title = Title;
            this.Genre = Genre; 
        }
    }
}
