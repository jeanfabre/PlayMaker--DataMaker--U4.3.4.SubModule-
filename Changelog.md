#DataMaker Change log

### 1.0.5  
**Fix**  
- Fixed proxy component refreshing system  
- Fixed `XmlInsertNode` insertAfter case  
 
### 1.0.4  
**Fix**  
- Fixed multiple Proxies per GameObject detection routine within custom Actions  

**Improvement**
- improve safety for `HashTableGetxmlNodeProperties` when property.innerText is null or empty


### 1.0.3  
**Fix**  
- Remove deprecated api call `VariableEditor.FsmVarPopup()` and replaced with custom popup from PlayMakerUtils library ( created for the purpose)  
- Improved safety for `HashTableGetXmlNodeProperties` when `property.innerText` is null or empty.


### 1.0.2  
**New**  
- Merged ArrayMaker Json Plugin into DataMaker (to avoid having to maintain this inside ArrayMaker)  
- Two Json library ( [newtonsoft for .net2.0](https://json.codeplex.com/) and a [custom version](http://techblog.procurios.nl/k/n618/news/view/14605/14863/how-do-i-write-my-own-parser-(for-json).html)), one for converting from json to xml and one for quick access. I went for this because both library have different usage and each have pros and cons

**Improvement**  
- ReOrganized Folders Structure ( to be compliant for submodules)  
- Distribution is now via Ecosystem

### 1.0.1
**New**  
- New actions _XmlProxyGetXmlAsString_ and _XmlProxyRefreshStringContent_ to better handle saving xml content as string  
- new _XmlNodeRemoveAll_ action
- new demo showing how to load and save xml in playerprefs

**Fix**  
- Fixed _XmlGetNextnodeListProperties_ cache  



**Improvement**  
- Added Reset option for _XmlGetNextnodeListProperties_  

**!!Deprecation!!**
- Removed StoreInMemory string property for _DataMakerXmlProxyEditor_  ( it's better to manually select the node you want from the proxy)

### 1.0.0
**New**  
- MIT License Addition  
- Support for Ecosystem changeLog and versioning   
- Added Refresh and Save In Project for _DataMakerXmlProxyEditor_ pointing to TextAssets  

**Fix**
- Fixed contentPreview missing skin on some Unity  versions, now using Label explicitly.  
- Fixed caching of xml string content in _DataMakerXmlProxyEditor_ to reduce scene size with uncessary editor only data  
- Adds ArrayMaker to the packages ( it has xml addons custom actions)


**Improvement**   
- Undo support when adding xml proxy composent to GameObject  
- Moved to [public Github Repository](https://github.com/jeanfabre/PlayMaker--DataMaker) for visibility and better code management safety.  
- Menus now under PlayMaker/Addons for better/compliant organisation  


###0.9.0
**Note**   
- Initial release
