using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "b4a6fa8d374dcf24")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IHero
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Featured Items
		///</summary>
		[ImplementPropertyType("featuredItems")]
		public IEnumerable<IPublishedContent> FeaturedItems
		{
			get { return Umbraco.Web.PublishedContentModels.Hero.GetFeaturedItems(this); }
		}

		///<summary>
		/// Slider
		///</summary>
		[ImplementPropertyType("slider")]
		public IEnumerable<IPublishedContent> Slider
		{
			get { return Umbraco.Web.PublishedContentModels.Hero.GetSlider(this); }
		}
	}

	/// <summary>Blog</summary>
	[PublishedContentModel("blog")]
	public partial class Blog : PublishedContentModel, ISubHeaderControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blog";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Blog(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Blog, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Large Heading: A large section heading that takes up the full width of the site
		///</summary>
		[ImplementPropertyType("largeHeading")]
		public string LargeHeading
		{
			get { return Umbraco.Web.PublishedContentModels.SubHeaderControls.GetLargeHeading(this); }
		}
	}

	/// <summary>Contact</summary>
	[PublishedContentModel("contact")]
	public partial class Contact : PublishedContentModel, ISubHeaderControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contact";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Contact(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Large Heading: A large section heading that takes up the full width of the site
		///</summary>
		[ImplementPropertyType("largeHeading")]
		public string LargeHeading
		{
			get { return Umbraco.Web.PublishedContentModels.SubHeaderControls.GetLargeHeading(this); }
		}
	}

	/// <summary>Content</summary>
	[PublishedContentModel("content")]
	public partial class Content : PublishedContentModel, IBasicContentControls, ISubHeaderControls, ITopNavigationControl
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "content";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Content(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Content, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Grid: Enter the content for the page
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// Large Heading: A large section heading that takes up the full width of the site
		///</summary>
		[ImplementPropertyType("largeHeading")]
		public string LargeHeading
		{
			get { return Umbraco.Web.PublishedContentModels.SubHeaderControls.GetLargeHeading(this); }
		}

		///<summary>
		/// Exclude From Top Navigation: Tick this if you don't want this page to appear in the top navigation
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return Umbraco.Web.PublishedContentModels.TopNavigationControl.GetExcludeFromTopNavigation(this); }
		}
	}

	// Mixin content Type 1088 with alias "subHeaderControls"
	/// <summary>Large Heading Controls</summary>
	public partial interface ISubHeaderControls : IPublishedContent
	{
		/// <summary>Large Heading</summary>
		string LargeHeading { get; }
	}

	/// <summary>Large Heading Controls</summary>
	[PublishedContentModel("subHeaderControls")]
	public partial class SubHeaderControls : PublishedContentModel, ISubHeaderControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "subHeaderControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SubHeaderControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SubHeaderControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Large Heading: A large section heading that takes up the full width of the site
		///</summary>
		[ImplementPropertyType("largeHeading")]
		public string LargeHeading
		{
			get { return GetLargeHeading(this); }
		}

		/// <summary>Static getter for Large Heading</summary>
		public static string GetLargeHeading(ISubHeaderControls that) { return that.GetPropertyValue<string>("largeHeading"); }
	}

	// Mixin content Type 1091 with alias "basicContentControls"
	/// <summary>Basic Content Controls</summary>
	public partial interface IBasicContentControls : IPublishedContent
	{
		/// <summary>Content Grid</summary>
		Newtonsoft.Json.Linq.JToken ContentGrid { get; }
	}

	/// <summary>Basic Content Controls</summary>
	[PublishedContentModel("basicContentControls")]
	public partial class BasicContentControls : PublishedContentModel, IBasicContentControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicContentControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicContentControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicContentControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Grid: Enter the content for the page
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return GetContentGrid(this); }
		}

		/// <summary>Static getter for Content Grid</summary>
		public static Newtonsoft.Json.Linq.JToken GetContentGrid(IBasicContentControls that) { return that.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("contentGrid"); }
	}

	// Mixin content Type 1093 with alias "topNavigationControl"
	/// <summary>Top Navigation Control</summary>
	public partial interface ITopNavigationControl : IPublishedContent
	{
		/// <summary>Exclude From Top Navigation</summary>
		bool ExcludeFromTopNavigation { get; }
	}

	/// <summary>Top Navigation Control</summary>
	[PublishedContentModel("topNavigationControl")]
	public partial class TopNavigationControl : PublishedContentModel, ITopNavigationControl
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "topNavigationControl";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TopNavigationControl(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TopNavigationControl, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Exclude From Top Navigation: Tick this if you don't want this page to appear in the top navigation
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return GetExcludeFromTopNavigation(this); }
		}

		/// <summary>Static getter for Exclude From Top Navigation</summary>
		public static bool GetExcludeFromTopNavigation(ITopNavigationControl that) { return that.GetPropertyValue<bool>("excludeFromTopNavigation"); }
	}

	/// <summary>Slide</summary>
	[PublishedContentModel("slide")]
	public partial class Slide : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "slide";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Slide(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Slide, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("image"); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public Umbraco.Web.Models.RelatedLinks Link
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("link"); }
		}

		///<summary>
		/// Text
		///</summary>
		[ImplementPropertyType("text")]
		public string Text
		{
			get { return this.GetPropertyValue<string>("text"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	// Mixin content Type 1106 with alias "hero"
	/// <summary>Hero</summary>
	public partial interface IHero : IPublishedContent
	{
		/// <summary>Featured Items</summary>
		IEnumerable<IPublishedContent> FeaturedItems { get; }

		/// <summary>Slider</summary>
		IEnumerable<IPublishedContent> Slider { get; }
	}

	/// <summary>Hero</summary>
	[PublishedContentModel("hero")]
	public partial class Hero : PublishedContentModel, IHero
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "hero";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Hero(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Hero, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Featured Items
		///</summary>
		[ImplementPropertyType("featuredItems")]
		public IEnumerable<IPublishedContent> FeaturedItems
		{
			get { return GetFeaturedItems(this); }
		}

		/// <summary>Static getter for Featured Items</summary>
		public static IEnumerable<IPublishedContent> GetFeaturedItems(IHero that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("featuredItems"); }

		///<summary>
		/// Slider
		///</summary>
		[ImplementPropertyType("slider")]
		public IEnumerable<IPublishedContent> Slider
		{
			get { return GetSlider(this); }
		}

		/// <summary>Static getter for Slider</summary>
		public static IEnumerable<IPublishedContent> GetSlider(IHero that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("slider"); }
	}

	/// <summary>Featured Item</summary>
	[PublishedContentModel("featuredItem")]
	public partial class FeaturedItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "featuredItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FeaturedItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FeaturedItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Category
		///</summary>
		[ImplementPropertyType("category")]
		public string Category
		{
			get { return this.GetPropertyValue<string>("category"); }
		}

		///<summary>
		/// Date
		///</summary>
		[ImplementPropertyType("date")]
		public DateTime Date
		{
			get { return this.GetPropertyValue<DateTime>("date"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("image"); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public Umbraco.Web.Models.RelatedLinks Link
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("link"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	// Mixin content Type 1115 with alias "articleControls"
	/// <summary>Article Controls</summary>
	public partial interface IArticleControls : IPublishedContent
	{
		/// <summary>Article Category</summary>
		string ArticleCategory { get; }

		/// <summary>Article Intro</summary>
		string ArticleIntro { get; }

		/// <summary>Atricle Publish Date</summary>
		DateTime AtriclePublishDate { get; }
	}

	/// <summary>Article Controls</summary>
	[PublishedContentModel("articleControls")]
	public partial class ArticleControls : PublishedContentModel, IArticleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "articleControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticleControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticleControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Category: Enter a category for the article
		///</summary>
		[ImplementPropertyType("articleCategory")]
		public string ArticleCategory
		{
			get { return GetArticleCategory(this); }
		}

		/// <summary>Static getter for Article Category</summary>
		public static string GetArticleCategory(IArticleControls that) { return that.GetPropertyValue<string>("articleCategory"); }

		///<summary>
		/// Article Intro: Enter the text to use as the introduction
		///</summary>
		[ImplementPropertyType("articleIntro")]
		public string ArticleIntro
		{
			get { return GetArticleIntro(this); }
		}

		/// <summary>Static getter for Article Intro</summary>
		public static string GetArticleIntro(IArticleControls that) { return that.GetPropertyValue<string>("articleIntro"); }

		///<summary>
		/// Atricle Publish Date: Enter the date that this arcile was published (Figure out how to auto do this)
		///</summary>
		[ImplementPropertyType("atriclePublishDate")]
		public DateTime AtriclePublishDate
		{
			get { return GetAtriclePublishDate(this); }
		}

		/// <summary>Static getter for Atricle Publish Date</summary>
		public static DateTime GetAtriclePublishDate(IArticleControls that) { return that.GetPropertyValue<DateTime>("atriclePublishDate"); }
	}

	/// <summary>Blog Post</summary>
	[PublishedContentModel("blogPost")]
	public partial class BlogPost : PublishedContentModel, IArticleControls, IBasicContentControls, ISubHeaderControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Category: Enter a category for the article
		///</summary>
		[ImplementPropertyType("articleCategory")]
		public string ArticleCategory
		{
			get { return Umbraco.Web.PublishedContentModels.ArticleControls.GetArticleCategory(this); }
		}

		///<summary>
		/// Article Intro: Enter the text to use as the introduction
		///</summary>
		[ImplementPropertyType("articleIntro")]
		public string ArticleIntro
		{
			get { return Umbraco.Web.PublishedContentModels.ArticleControls.GetArticleIntro(this); }
		}

		///<summary>
		/// Atricle Publish Date: Enter the date that this arcile was published (Figure out how to auto do this)
		///</summary>
		[ImplementPropertyType("atriclePublishDate")]
		public DateTime AtriclePublishDate
		{
			get { return Umbraco.Web.PublishedContentModels.ArticleControls.GetAtriclePublishDate(this); }
		}

		///<summary>
		/// Content Grid: Enter the content for the page
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// Large Heading: A large section heading that takes up the full width of the site
		///</summary>
		[ImplementPropertyType("largeHeading")]
		public string LargeHeading
		{
			get { return Umbraco.Web.PublishedContentModels.SubHeaderControls.GetLargeHeading(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
