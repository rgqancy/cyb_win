
// MiniTool.h : MiniTool Ӧ�ó������ͷ�ļ�
//
#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"       // ������


// CMiniToolApp:
// �йش����ʵ�֣������ MiniTool.cpp
//

class CMiniToolApp : public CWinApp
{
public:
	CMiniToolApp();


// ��д
public:
	virtual BOOL InitInstance();
	virtual int ExitInstance();

// ʵ��

public:
	afx_msg void OnAppAbout();
	DECLARE_MESSAGE_MAP()
};

extern CMiniToolApp theApp;
