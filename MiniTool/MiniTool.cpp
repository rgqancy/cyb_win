
// MiniTool.cpp : ����Ӧ�ó��������Ϊ��
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


// CMiniToolApp ����

CMiniToolApp::CMiniToolApp()
{
	// TODO: ������Ӧ�ó��� ID �ַ����滻ΪΨһ�� ID �ַ�����������ַ�����ʽ
	//Ϊ CompanyName.ProductName.SubProduct.VersionInformation
	SetAppID(_T("MiniTool.AppID.NoVersion"));

	// TODO: �ڴ˴���ӹ�����룬
	// ��������Ҫ�ĳ�ʼ�������� InitInstance ��
}

// Ψһ��һ�� CMiniToolApp ����

CMiniToolApp theApp;


// CMiniToolApp ��ʼ��

BOOL CMiniToolApp::InitInstance()
{
	// ���һ�������� Windows XP �ϵ�Ӧ�ó����嵥ָ��Ҫ
	// ʹ�� ComCtl32.dll �汾 6 ����߰汾�����ÿ��ӻ���ʽ��
	//����Ҫ InitCommonControlsEx()�����򣬽��޷��������ڡ�
	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);
	// ��������Ϊ��������Ҫ��Ӧ�ó�����ʹ�õ�
	// �����ؼ��ࡣ
	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinApp::InitInstance();


	EnableTaskbarInteraction(FALSE);

	// ʹ�� RichEdit �ؼ���Ҫ  AfxInitRichEdit2()	
	// AfxInitRichEdit2();

	// ��׼��ʼ��
	// ���δʹ����Щ���ܲ�ϣ����С
	// ���տ�ִ���ļ��Ĵ�С����Ӧ�Ƴ�����
	// ����Ҫ���ض���ʼ������
	// �������ڴ洢���õ�ע�����
	// TODO: Ӧ�ʵ��޸ĸ��ַ�����
	// �����޸�Ϊ��˾����֯��
	SetRegistryKey(_T("Ӧ�ó��������ɵı���Ӧ�ó���"));


	// ��Ҫ���������ڣ��˴��뽫�����µĿ�ܴ���
	// ����Ȼ��������ΪӦ�ó���������ڶ���
	CMainFrame* pFrame = new CMainFrame;
	if (!pFrame)
		return FALSE;
	m_pMainWnd = pFrame;
	// ���������ؿ�ܼ�����Դ
	pFrame->LoadFrame(IDR_MAINFRAME,
		WS_OVERLAPPEDWINDOW | FWS_ADDTOTITLE, NULL,
		NULL);






	// Ψһ��һ�������ѳ�ʼ���������ʾ����������и���
	pFrame->ShowWindow(SW_SHOW);
	pFrame->UpdateWindow();
	// �������к�׺ʱ�ŵ��� DragAcceptFiles
	//  �� SDI Ӧ�ó����У���Ӧ�� ProcessShellCommand ֮����
	return TRUE;
}

int CMiniToolApp::ExitInstance()
{
	//TODO: �����������ӵĸ�����Դ
	return CWinApp::ExitInstance();
}

// CMiniToolApp ��Ϣ�������


// ����Ӧ�ó��򡰹��ڡ��˵���� CAboutDlg �Ի���

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// �Ի�������
	enum { IDD = IDD_ABOUTBOX };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV ֧��

// ʵ��
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

// �������жԻ����Ӧ�ó�������
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

// CMiniToolApp ��Ϣ�������





void CAboutDlg::OnEnChangeMfceditbrowse1()
{
	// TODO:  ����ÿؼ��� RICHEDIT �ؼ���������
	// ���ʹ�֪ͨ��������д CDialogEx::OnInitDialog()
	// ���������� CRichEditCtrl().SetEventMask()��
	// ͬʱ�� ENM_CHANGE ��־�������㵽�����С�

	// TODO:  �ڴ���ӿؼ�֪ͨ����������
}


void CAboutDlg::OnAppAbout()
{
	// TODO: �ڴ���������������
}


void CAboutDlg::OnBnClickedButtonselect()
{
	//���EDIT

	CEdit* pBoxOne;
	pBoxOne = (CEdit*) GetDlgItem(IDC_MFCEDITBROWSE);

	//ȡֵ
	CString str;
	pBoxOne->GetWindowText(str);

	//��ֵ
	pBoxOne->SetWindowText(_T(""));


	CEdit* pFileList = (CEdit*) GetDlgItem(IDC_EDITFILELIST);
	
	CString fileList;
	pFileList->GetWindowTextW(fileList);

	pFileList->SetWindowTextW(fileList+str+_T("\r\n"));

	//pFileList->SetWindowTextW(_T("abc\r\ndef"));
}


void CAboutDlg::OnBnClickedButtonmd5()
{
	// TODO: �ڴ���ӿؼ�֪ͨ����������
}
