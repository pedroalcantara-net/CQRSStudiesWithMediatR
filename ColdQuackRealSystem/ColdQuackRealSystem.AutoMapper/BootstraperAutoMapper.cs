using AutoMapper;
using ColdQuackRealSystem.AutoMapper.Profiles;

namespace ColdQuackRealSystem.AutoMapper
{
    public class BootstraperAutoMapper
    {
        public static Action<IMapperConfigurationExpression> ConfigAction = new Action<IMapperConfigurationExpression>(cfg =>
        {
            cfg.AllowNullCollections = true;
            cfg.AllowNullDestinationValues = true;
            cfg.AddProfile<CoreEntities>();
        });
    }
}
