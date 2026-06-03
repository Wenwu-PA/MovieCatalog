using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace VideoLibrary
{
    public static class XmlManager
    {
        private static string xmlFile = "movies.xml";

        public static void SaveMovies(List<Movie> movies)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>));
            using (StreamWriter writer = new StreamWriter(xmlFile))
            {
                serializer.Serialize(writer, movies);
            }
        }

        public static List<Movie> LoadMovies()
        {
            if (!File.Exists(xmlFile)) return new List<Movie>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>));
            using (StreamReader reader = new StreamReader(xmlFile))
            {
                return (List<Movie>)serializer.Deserialize(reader);
            }
        }
    }
}