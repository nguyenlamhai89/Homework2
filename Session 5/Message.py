from gmail import *
import random

reasons = ['troi mua', 'em di tham anh Huy bi tai nan giao thong', 'em gay chan', 'em thich the']
reason = random.choice(reasons)
gmail = GMail('nguyenlamhai89@gmail.com','nguyenlamhai2000')
msg = Message('NGHI HOC DEEE!!!!!',to='123abcxyz@gmail.com',text = 'Hom nay e xin phep nghi vi ' + reason + ' ahihi')

gmail.send(msg)

