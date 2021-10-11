#if defined(GMS_PLATFORM_WINDOWS)
#define EXTERN extern "C" __declspec(dllexport)
#elif defined(GMS_PLATFORM_UBUNTU)
#define EXTERN extern "C"
#elif defined(GMS_PLATFORM_MACOS)
#define EXTERN extern "C"
#elif defined(GMS_PLATFORM_HTML5)
#include <emscripten/emscripten.h>
#define EXTERN extern "C" EMSCRIPTEN_KEEPALIVE
#else
#define EXTERN
#endif

EXTERN double give_me_five(double five=5.0) {
    return five;
}
