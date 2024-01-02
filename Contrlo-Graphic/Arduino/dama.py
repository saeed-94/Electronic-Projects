import random
from drawnow import *
import matplotlib.pyplot as plt

listtemp=[]
listcold=[]
listnormal=[]
listheat=[]
temp=0

def coldtemp():
    plt.ylim(2,150)
    plt.title('temp cold')
    plt.grid(True)
    plt.plot(listcold,'ro-',label='Cold')

def normaltemp():
    plt.ylim(2,150)
    plt.title('temp normal')
    plt.grid(True)
    plt.plot(listnormal,'ro-',label='Normal')

def heattemp():
    plt.ylim(2,150)
    plt.title('temp heat')
    plt.grid(True)
    plt.plot(listheat,'ro-',label='Heat')

while(temp<150):
    temp= random.randint(0,150)
    #temp=temp//1023
    if (temp<20):
        listcold.append(temp)
        drawnow(coldtemp)

    elif (temp<40):
        listnormal.append(temp)
        drawnow(normaltemp)

    elif (temp<100):
        listheat.append(temp)
        drawnow(heattemp)

    elif (temp<130):
        continue
    else:
        break
print("clod temp:",listcold)
print("***************")
print("normal temp:",listnormal)
print("***************")
print("heat temp",listheat)
