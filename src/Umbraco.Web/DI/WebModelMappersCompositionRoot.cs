using LightInject;
using Umbraco.Web.Models.Mapping;

namespace Umbraco.Web.DI
{
    public sealed class WebModelMappersCompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry container)
        {
            container.Register<ContentModelMapper>();
            container.Register<ContentPropertyModelMapper>();
            container.Register<ContentTypeModelMapper>();
            container.Register<DataTypeModelMapper>();
            container.Register<EntityModelMapper>();
            container.Register<MacroModelMapper>();
            container.Register<MediaModelMapper>();
            container.Register<MemberModelMapper>();
            container.Register<RelationModelMapper>();
            container.Register<SectionModelMapper>();
            container.Register<TabModelMapper>();
            container.Register<UserModelMapper>();
            container.Register<DashboardModelsMapper>();
        }
    }
}