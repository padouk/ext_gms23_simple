#ifdef GMS_PLATFORM_LINUX
#define EXTERN extern "C"
#else
#define EXTERN
#endif

EXTERN double give_me_five() {
    return 5.0;
}
