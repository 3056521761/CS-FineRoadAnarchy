﻿using FineRoadAnarchy.Redirection;

namespace FineRoadAnarchy.Detours
{
    [TargetType(typeof(NetInfo))]
    public class NetInfoDetour : NetInfo
    {
        [RedirectMethod]
        new public float GetMinNodeDistance()
        {
            if(!FineRoadAnarchy.snapping)
            {
                return 3f;
            }
            if (this.m_halfWidth < 3.5f)
            {
                return 7f;
            }
            if (this.m_halfWidth < 7.5f)
            {
                return 15f;
            }
            return 23f;
        }
    }
}
