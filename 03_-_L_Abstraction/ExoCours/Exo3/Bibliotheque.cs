using System;

namespace Exo2
{
    public class Bibliotheque
    {
        private Document[] _documents;


        public Bibliotheque(int numberPlaces)
        {
            _documents = new Document[numberPlaces];
        }

        public void AfficherDocuments()
        {
            foreach(Document document in _documents)
            {
                if(document != null)
                {
                    Console.WriteLine(document);
                }
            }
        }

        public bool AddDocument(Document doc)
        {
            for(int i = 0; i <_documents.Length; i++)
            {
                if(_documents[i] == null)
                {
                    _documents[i] = doc;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveDocument(Document doc)
        {
            for(int i = 0; i <_documents.Length; i++)
            {
                if(_documents[i] == doc)
                {
                    _documents[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void DisplayAuthor()
        {
            foreach(Document document in _documents)
            {
                if(document is Livre livre)
                {
                    Console.WriteLine(livre.Author);
                }
            }
        }
    }
}