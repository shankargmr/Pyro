﻿using Pyro.Common.Interfaces.Repositories;
using Hl7.Fhir.Model;
using Pyro.Common.CompositionRoot;
using Pyro.DataLayer.Repository.Interfaces;

namespace Pyro.WebApi.CompositionRoot
{
  public class ResourceRepositoryFactory : IResourceRepositoryFactory
  {
    private readonly SimpleInjector.Container Container;

    public ResourceRepositoryFactory(SimpleInjector.Container Container)
    {
      this.Container = Container;
    }

    public IResourceRepository Create<ResCurrentType, ResIndexStringType, ResIndexTokenType, ResIndexUriType, ResIndexReferenceType, ResIndexQuantityType, ResIndexDateTimeType>(FHIRAllTypes FHIRAllTypes)
    {
      var CommonResourceRepository = (ICommonResourceRepository<ResCurrentType, ResIndexStringType, ResIndexTokenType, ResIndexUriType, ResIndexReferenceType, ResIndexQuantityType, ResIndexDateTimeType>)Container.GetInstance(typeof(ICommonResourceRepository<ResCurrentType, ResIndexStringType, ResIndexTokenType, ResIndexUriType, ResIndexReferenceType, ResIndexQuantityType, ResIndexDateTimeType>));
      CommonResourceRepository.RepositoryResourceType = FHIRAllTypes;
      return CommonResourceRepository;
    }

    
  }
}