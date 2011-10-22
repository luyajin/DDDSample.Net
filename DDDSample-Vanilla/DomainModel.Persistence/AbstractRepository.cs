﻿using NHibernate;

namespace DDDSample.DomainModel.Persistence
{
   /// <summary>
   /// Base class for NHibernate based repositories.
   /// </summary>
   public abstract class AbstractRepository
   {
      protected ISessionFactory SessionFactory { get; private set; }

      protected AbstractRepository(ISessionFactory sessionFactory)
      {
         SessionFactory = sessionFactory;
      }

      protected ISession Session
      {
         get { return SessionFactory.GetCurrentSession(); }
      }
   }
}
