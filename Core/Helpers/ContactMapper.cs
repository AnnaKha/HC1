using AutoMapper;
using Core.Models;

namespace Core.Helpers
{
	public class ContactMapper
	{
		public ContactWithSearchInfo MapToContactWithSearchContactInfoOnly(Contact contact)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<Contact, ContactWithSearchInfo>());
			return Mapper.Map<Contact, ContactWithSearchInfo>(contact);
		}

		public ContactWithRequiredInfo MapToContactWithRequiredInfoOnly(Contact contact)
		{
			Mapper.Initialize(i => i.CreateMap<Contact, ContactWithRequiredInfo>());
			return Mapper.Map<Contact, ContactWithRequiredInfo>(contact);
		}

		public AdditionalAddress MapToContactAddressInfoOnly(Contact contact)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<Contact, AdditionalAddress>());
			return Mapper.Map<Contact, AdditionalAddress>(contact);
		}
	}
}
