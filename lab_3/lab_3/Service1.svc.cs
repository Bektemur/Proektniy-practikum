using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace lab_3
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        public DataBase db = new DataBase();
        public Service GetService(int id)
        {
            Service service = db.Service.Find(id);
            return db.Service.Find(id);
        }
        public IEnumerable<Service> GetServices()
        {
            return db.Service.ToList();
        }

        public int ServiceAdd (Service service)
        {
            db.Service.Add(service);
            return db.SaveChanges();
        }
        public int ServicePut(int id, Service value)
        {
            var entity = db.Service.FirstOrDefault(e => e.Id_service == id);
                entity.Name_service = value.Name_service; 
                return db.SaveChanges();
        }
        public int ServiceDelete(int id, Service value)
        {
            Service service = db.Service.Find(id);
            db.Service.Remove(service);
            return db.SaveChanges();   
        }


        public Client GetClient(int id)
        {
            Client service = db.Client.Find(id);
            return db.Client.Find(id);
        }
        public IEnumerable<Client> GetClient()
        {
            return db.Client.ToList();
        }

        public int ClientAdd(Client service)
        {
            db.Client.Add(service);
            return db.SaveChanges();
        }
        public int ClientPut(int id, Client value)
        {
            var entity = db.Client.FirstOrDefault(e => e.ID_Clienta == id);
            entity.FIO = value.FIO;
            return db.SaveChanges();
        }
        public int ClientDelete(int id, Client value)
        {
            Client service = db.Client.Find(id);
            db.Client.Remove(service);
            return db.SaveChanges();
        }



        public Zayavki GetZayavki(int id)
        {
            Zayavki service = db.Zayavki.Find(id);
            return db.Zayavki.Find(id);
        }
        public IEnumerable<Zayavki> GetZayavki()
        {
            return db.Zayavki.ToList();
        }

        public int ZayavkiAdd(Zayavki service)
        {
            db.Zayavki.Add(service);
            return db.SaveChanges();
        }
        public int ZayavkiPut(int id, Zayavki value)
        {
            var entity = db.Zayavki.FirstOrDefault(e => e.Id_zakazi == id);
            entity.Id_service = value.Id_service;
            entity.Id_clienta = value.Id_clienta;
            return db.SaveChanges();
        }
        public int ZayavkiDelete(int id, Zayavki value)
        {
            Zayavki service = db.Zayavki.Find(id);
            db.Zayavki.Remove(service);
            return db.SaveChanges();
        }

    }
}
