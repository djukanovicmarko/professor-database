using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Domaci5
{
    class ProfesoriXML
    {
        // Metoda koja ucitava XML dokument sa zadate putanje 
        // na racunaru, parsira podatke i upisuje ih u bazu podataka
        public static void uveziXML(string putanja)
        {
            // Kreira se instanca klase koja predstavlja XML dokument
            XmlDocument xmlDoc = new XmlDocument();
            // Ucitava se dokument sa zadate putanje
            xmlDoc.Load(putanja);
            // Kreira se kolekcija cvorova na osnovu XML dokumenta
            // Kolekciju cine elementi cije je ime taga "Student"
            XmlNodeList profesoriNodes =
                xmlDoc.GetElementsByTagName("Profesor");
            // Prolazi se kroz svaki element u kolekciji
            foreach (XmlNode profesorNode in profesoriNodes)
            {
                // Kreiramo novu instancu klase Student
                // kojoj dodeljujemo vrednosti za clanove na osnovu 
                // vrednosti unutrasnjih cvorova u XML-u
                Profesor prof = new Profesor();
                prof.Ime = profesorNode.ChildNodes[0].InnerText;
                prof.Prezime = profesorNode.ChildNodes[1].InnerText;
                prof.Zvanje = profesorNode.ChildNodes[2].InnerText;
                prof.Katedra = profesorNode.ChildNodes[3].InnerText;
                // Dati student se dodaje u bazu podataka
                prof.dodajProfesora();
            }
        }

        // Metoda koja listu podataka cuva kao XML dokument 
        // na zadatoj putanji
        public static Boolean izveziXML(string putanja, List<Profesor> profesori)
        {
            // Kreira se instanca klase koja predstavlja XML dokument
            XmlDocument xmlDoc = new XmlDocument();
            // Kreira se instanca klase koja omogucava upis u XML 
            // dokument koji se nalazi na zadatoj putanji, pri cemu
            // ce tekst biti enkodiran po UTF8 standardu
            XmlTextWriter xmlWriter =
                new XmlTextWriter(putanja, System.Text.Encoding.UTF8);
            //xmlWriter.Formatting = Formatting.Indented;
            // Upisuje se zaglavlje XML fajla
            xmlWriter.WriteProcessingInstruction(
                "xml", "version='1.0' encoding='UTF-8'");
            // Upisujemo startni element
            xmlWriter.WriteStartElement("Profesori");
            // Zatvaramo dokument koji sada predstavlja regularni XML
            // dokument sa zaglavljem i startnim elementom, pa moze
            // biti ucitan pomocu xmlDoc.Load metode. 
            xmlWriter.Close();
            xmlDoc.Load(putanja);

            // Prolazimo kroz sve studente koji se nalaze u listi
            foreach (Profesor prof in profesori)
            {
                // Kreiramo novi XML cvor  - Student
                XmlElement profesorNode = xmlDoc.CreateElement("Profesor");

                // Kreiramo novi XML cvor - ImeStudenta
                XmlElement imeProfesora = xmlDoc.CreateElement("ImeProfesora");
                // Sadrzaj elementa je ime trenutno ucitanog studenta
                imeProfesora.InnerText = prof.Ime;
                // Dodavanje novog cvora u cvor studentNode
                profesorNode.AppendChild(imeProfesora);

                // Kreiramo novi XML cvor - PrezimeStudenta
                XmlElement prezimeProfesora =
                    xmlDoc.CreateElement("PrezimeProfesora");
                // Sadrzaj elementa je prezime trenutno ucitanog studenta
                prezimeProfesora.InnerText = prof.Prezime;
                // Dodavanje novog cvora u cvor studentNode
                profesorNode.AppendChild(prezimeProfesora);

                // Kreiramo novi XML cvor - Smer
                XmlElement zvanje = xmlDoc.CreateElement("Zvanje");
                // Sadrzaj elementa je smer trenutno ucitanog studenta
                zvanje.InnerText = prof.Zvanje;
                // Dodavanje novog cvora u cvor studentNode
                profesorNode.AppendChild(zvanje);

                // Kreiramo novi XML cvor - Prosek
                XmlElement katedra = xmlDoc.CreateElement("Katedra");
                // Sadrzaj elementa je prosek trenutno ucitanog studenta
                katedra.InnerText = prof.Katedra;
                // Dodavanje novog cvora u cvor studentNode
                profesorNode.AppendChild(katedra);

                // Dodavanje cvora u dokument
                xmlDoc.DocumentElement.InsertAfter(
                    profesorNode, xmlDoc.DocumentElement.LastChild);
            }
            // Cuvanje dokumenta
            xmlDoc.Save(putanja);
            return true;
        }
    }


    }

