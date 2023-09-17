#pragma once

#include <stdint.h>

namespace Unity
{
    struct Range
    {
        int32_t start;
        int32_t length;

        Range()
            : start(0)
            , length(0)
        {
        }

        Range(int32_t start, int32_t length)
            : start(start)
            , length(length)
        {
        }
    };
}
