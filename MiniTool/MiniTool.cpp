
// MiniTool.cpp : 定义应用程序的类行为。
//

#include "stdafx.h"
#include "afxwinappex.h"
#include "afxdialogex.h"
#include "MiniTool.h"
#include "MainFrm.h"


#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CMiniToolApp

BEGIN_MESSAGE_MAP(CMiniToolApp, CWinApp)
	ON_COMMAND(ID_APP_ABOUT, &CMiniToolApp::OnAppAbout)
END_MESSAGE_MAP()


// CMiniToolApp 构造

CMiniToolApp::CMiniToolApp()
{
	// TODO: 将以下应用程序 ID 字符串替换为唯一的 ID 字符串；建议的字符串格式
	//为 CompanyName.ProductName.SubProduct.VersionInformation
	SetAppID(_T("MiniTool.AppID.NoVersion"));

	// TODO: 在此处添加构造代码，
	// 将所有重要的初始化放置在 InitInstance 中
}

// 唯一的一个 CMiniToolApp 对象

CMiniToolApp theApp;


// CMiniToolApp 初始化

BOOL CMiniToolApp::InitInstance()
{
	// 如果一个运行在 Windows XP 上的应用程序清单指定要
	// 使用 ComCtl32.dll 版本 6 或更高版本来启用可视化方式，
	//则需要 InitCommonControlsEx()。否则，将无法创建窗口。
	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);
	// 将它设置为包括所有要在应用程序中使用的
	// 公共控件类。
	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinApp::InitInstance();


	EnableTaskbarInteraction(FALSE);

	// 使用 RichEdit 控件需要  AfxInitRichEdit2()	
	// AfxInitRichEdit2();

	// 标准初始化
	// 如果未使用这些功能并希望减小
	// 最终可执行文件的大小，则应移除下列
	// 不需要的特定初始化例程
	// 更改用于存储设置的注册表项
	// TODO: 应适当修改该字符串，
	// 例如修改为公司或组织名
	SetRegistryKey(_T("应用程序向导生成的本地应用程序"));


	// 若要创建主窗口，此代码将创建新的框架窗口
	// 对象，然后将其设置为应用程序的主窗口对象
	CMainFrame* pFrame = new CMainFrame;
	if (!pFrame)
		return FALSE;
	m_pMainWnd = pFrame;
	// 创建并加载框架及其资源
	pFrame->LoadFrame(IDR_MAINFRAME,
		WS_OVERLAPPEDWINDOW | FWS_ADDTOTITLE, NULL,
		NULL);






	// 唯一的一个窗口已初始化，因此显示它并对其进行更新
	pFrame->ShowWindow(SW_SHOW);
	pFrame->UpdateWindow();
	// 仅当具有后缀时才调用 DragAcceptFiles
	//  在 SDI 应用程序中，这应在 ProcessShellCommand 之后发生
	return TRUE;
}

int CMiniToolApp::ExitInstance()
{
	//TODO: 处理可能已添加的附加资源
	return CWinApp::ExitInstance();
}

// CMiniToolApp 消息处理程序


// 用于应用程序“关于”菜单项的 CAboutDlg 对话框

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// 对话框数据
	enum { IDD = IDD_ABOUTBOX };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支持

// 实现
protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnEnChangeMfceditbrowse1();
	afx_msg void OnAppAbout();
	afx_msg void OnBnClickedButtonselect();
	afx_msg void OnBnClickedButtonmd5();
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
	ON_EN_CHANGE(IDC_MFCEDITBROWSE1, &CAboutDlg::OnEnChangeMfceditbrowse1)
	ON_COMMAND(ID_APP_ABOUT, &CAboutDlg::OnAppAbout)
	ON_BN_CLICKED(IDC_BUTTONSELECT, &CAboutDlg::OnBnClickedButtonselect)
	ON_BN_CLICKED(IDC_BUTTONMD5, &CAboutDlg::OnBnClickedButtonmd5)
END_MESSAGE_MAP()

// 用于运行对话框的应用程序命令
void CMiniToolApp::OnAppAbout()
{
	CAboutDlg aboutDlg;
	aboutDlg.DoModal();

	/*
	static   char   sz_filter[]   =   "JPG/BMP|*.jpg;*.bmp|| ";
	CFileDialog   selectfile_dlg(TRUE,NULL,NULL,OFN_HIDEREADONLY|OFN_OVERWRITEPROMPT|   OFN_ALLOWMULTISELECT,sz_filter,NULL); 
	char   bigBuff[2048]   =   "";     
	selectfile_dlg.m_ofn.lpstrFile  =   bigBuff; 
	selectfile_dlg.m_ofn.nMaxFile   =   sizeof(bigBuff); 
	selectfile_dlg.DoModal(); 
	POSITION   pos   =   selectfile_dlg.GetStartPosition(); 
	TCHAR   buf_share_filename[MAX_PATH]; 
	//GetShareFileName(buf_share_filename);
	//DebugMsg(buf_share_filename);
	while(   pos   ) 
	{ 
		CString   one_filename=selectfile_dlg.GetNextPathName(   pos   ); 

	}
	*/
}

// CMiniToolApp 消息处理程序





void CAboutDlg::OnEnChangeMfceditbrowse1()
{
	// TODO:  如果该控件是 RICHEDIT 控件，它将不
	// 发送此通知，除非重写 CDialogEx::OnInitDialog()
	// 函数并调用 CRichEditCtrl().SetEventMask()，
	// 同时将 ENM_CHANGE 标志“或”运算到掩码中。

	// TODO:  在此添加控件通知处理程序代码
}


void CAboutDlg::OnAppAbout()
{
	// TODO: 在此添加命令处理程序代码
}


void CAboutDlg::OnBnClickedButtonselect()
{
	//获得EDIT

	CEdit* pBoxOne;
	pBoxOne = (CEdit*) GetDlgItem(IDC_MFCEDITBROWSE);

	//取值
	CString str;
	pBoxOne->GetWindowText(str);

	//付值
	pBoxOne->SetWindowText(_T(""));


	CEdit* pFileList = (CEdit*) GetDlgItem(IDC_EDITFILELIST);
	
	CString fileList;
	pFileList->GetWindowTextW(fileList);

	pFileList->SetWindowTextW(fileList+str+_T("\r\n"));

	//pFileList->SetWindowTextW(_T("abc\r\ndef"));
}


void CAboutDlg::OnBnClickedButtonmd5()
{
	// TODO: 在此添加控件通知处理程序代码
}
