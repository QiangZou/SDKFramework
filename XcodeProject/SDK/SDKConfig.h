//
//  SDKConfig.hpp
//  Unity-iPhone
//
//  Created by zouqiang on 2018/5/25.
//

#ifndef SDKConfig_hpp
#define SDKConfig_hpp

#include <stdio.h>
//#include "SDKMessage.h"
//#include "SDKFramework.hpp"

#endif /* SDKConfig_hpp */

//extern  const char* MakeStringCopy (const char* string);

const char* MakeStringCopy (const char* string)
{
    if (string == NULL)
    {
        return NULL;
    }
    char* res = (char*)malloc(strlen(string) + 1);
    memset(res,0,strlen(string) + 1);
    strcpy(res, string);
    return res;
    
}

const char * ChannelName()
{
    return MakeStringCopy("xiaomu");
}


const char* LoginSDK()
{
    SDKMessage * message = new SDKMessage((int)LoginSucceed);
    
    message->UserID = MakeStringCopy("1234567a");
    
    NSDictionary *dict = @{
                           @"Type" :[NSString stringWithFormat:@"%d", message->Type],
                           @"UserID" :[NSString stringWithFormat:@"%s", message->UserID]
                           };
    
    BOOL isYes = [NSJSONSerialization isValidJSONObject:dict];
    
    if (isYes)
    {
        
        NSData *jsonData = [NSJSONSerialization dataWithJSONObject:dict options:0 error:NULL];
     
        const char * data =[[[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding] UTF8String] ;
        
        UnitySendMessage("SDKManager", "SDKToUnity", data);
    }
    
    
    return MakeStringCopy("");
}


const char* LogoutSDK()
{
    return MakeStringCopy("");
}


const char* UploadInfoSDK()
{
    return MakeStringCopy("");
}


const char* PaySDK()
{
    return MakeStringCopy("");
}


const char* Method0SDK()
{
    return MakeStringCopy("");
}


const char* Method1SDK()
{
    return MakeStringCopy("");
}


const char* Method2SDK()
{
    return MakeStringCopy("");
}


const char* Method3SDK()
{
    return MakeStringCopy("");
}


const char* Method4SDK()
{
    return MakeStringCopy("");
}

