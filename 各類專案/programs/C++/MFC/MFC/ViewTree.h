
#pragma once

/////////////////////////////////////////////////////////////////////////////
// CViewTree 視窗

class CViewTree : public CTreeCtrl
{
// 建構
public:
	CViewTree();

// 覆寫
protected:
	virtual BOOL OnNotify(WPARAM wParam, LPARAM lParam, LRESULT* pResult);

// 程式碼實作
public:
	virtual ~CViewTree();

protected:
	DECLARE_MESSAGE_MAP()
};
