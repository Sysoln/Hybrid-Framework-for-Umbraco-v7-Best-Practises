//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Zbu.ModelsBuilder v2.0.0.26
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Zbu.ModelsBuilder;
using Zbu.ModelsBuilder.Umbraco;

namespace Umbraco.Extensions.Models.Generated
{
	/// <summary>Newsitem</summary>
	[PublishedContentModel("Newsitem")]
	public partial class Newsitem : Base
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Newsitem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Newsitem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Newsitem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}


		/// <summary>Text</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		/// <summary>Date</summary>
		[ImplementPropertyType("currentDate")]
		public DateTime CurrentDate
		{
			get { return this.GetPropertyValue<DateTime>("currentDate"); }
		}

		/// <summary>Hide on news</summary>
		[ImplementPropertyType("hideOnNews")]
		public bool HideOnNews
		{
			get { return this.GetPropertyValue<bool>("hideOnNews"); }
		}

		/// <summary>Image</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Extensions.Models.Generated.Image Image
		{
			get { return this.GetPropertyValue<Umbraco.Extensions.Models.Generated.Image>("image"); }
		}

		/// <summary>Title</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}
}
