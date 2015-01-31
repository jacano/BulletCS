#
# Bullet Physics Static Library
# 

LOCAL_PATH := ../../bullet-2.83-alpha
include $(CLEAR_VARS)

LOCAL_MODULE := libbullet
FILE_LIST := $(wildcard $(LOCAL_PATH)/BulletCollision/**/*.cpp)
FILE_LIST += $(wildcard $(LOCAL_PATH)/BulletDynamics/**/*.cpp)
FILE_LIST += $(wildcard $(LOCAL_PATH)/LinearMath/*.cpp)

LOCAL_SRC_FILES := $(FILE_LIST:$(LOCAL_PATH)/%=%)

include $(BUILD_STATIC_LIBRARY)

#
# Bullet Physics Shared Library With Wrapper
# 

LOCAL_PATH := ../../bullet-2.83-alpha
include $(CLEAR_VARS)

LOCAL_MODULE := libbulletwrap
FILE_LIST := $(wildcard $(LOCAL_PATH)/wrapper/*.cpp)
LOCAL_SRC_FILES := $(FILE_LIST:$(LOCAL_PATH)/%=%)

LOCAL_C_INCLUDES := $(LOCAL_PATH)

LOCAL_STATIC_LIBRARIES := libbullet 
LOCAL_LDLIBS := -ldl -llog -landroid -lz

include $(BUILD_SHARED_LIBRARY)
